using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace NATOAlphabet;

public static class NatoExtensions
{
    private static readonly Dictionary<char, string> _map = new Dictionary<char, string>(26)
    {
        ['A'] = "Alpha",
        ['B'] = "Bravo",
        ['C'] = "Charlie",
        ['D'] = "Delta",
        ['E'] = "Echo",
        ['F'] = "Foxtrot",
        ['G'] = "Golf",
        ['H'] = "Hotel",
        ['I'] = "India",
        ['J'] = "Juliett",
        ['K'] = "Kilo",
        ['L'] = "Lima",
        ['M'] = "Mike",
        ['N'] = "November",
        ['O'] = "Oscar",
        ['P'] = "Papa",
        ['Q'] = "Quebec",
        ['R'] = "Romeo",
        ['S'] = "Sierra",
        ['T'] = "Tango",
        ['U'] = "Uniform",
        ['V'] = "Victor",
        ['W'] = "Whiskey",
        ['X'] = "Xray",
        ['Y'] = "Yankee",
        ['Z'] = "Zulu"
    };

    /// <summary>
    /// Converts letters in the input string to NATO phonetic words.
    /// Non-letter characters are preserved as-is and separated by the separator.
    /// Accents are removed before mapping (e.g. 'É' -> 'E').
    /// Example: "Hi!" -> "Hotel India !"
    /// </summary>
    public static string ToNato(this string? input, string separator = " ")
    {
        if (string.IsNullOrEmpty(input))
            return string.Empty;

        string normalized = input.Normalize(NormalizationForm.FormD);
        var tokens = new List<string>();

        foreach (var ch in normalized)
        {
            var uc = CharUnicodeInfo.GetUnicodeCategory(ch);
            if (uc == UnicodeCategory.NonSpacingMark)
                continue;

            char upper = char.ToUpperInvariant(ch);
            if (_map.TryGetValue(upper, out var word))
            {
                tokens.Add(word);
            }
            else if (char.IsWhiteSpace(ch))
            {
                if (tokens.Count == 0 || tokens[tokens.Count - 1] != string.Empty)
                    tokens.Add(string.Empty);
            }
            else
            {
                tokens.Add(ch.ToString());
            }
        }

        return string.Join(separator, tokens).Trim();
    }
}
