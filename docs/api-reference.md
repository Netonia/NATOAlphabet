# API Reference

## NatoExtensions Class

The `NatoExtensions` class provides extension methods for converting strings to NATO phonetic alphabet representation.

**Namespace:** `NATOAlphabet`

## Methods

### ToNato

Converts letters in the input string to NATO phonetic words.

```csharp
public static string ToNato(this string? input, string separator = " ")
```

#### Parameters

- **input** (`string?`): The input string to convert. Can be `null`.
- **separator** (`string`, optional): The separator to use between NATO words and non-letter characters. Default is a single space `" "`.

#### Returns

- **Type:** `string`
- **Description:** A string containing the NATO phonetic representation of the input. Non-letter characters are preserved as separate tokens. Returns an empty string if the input is `null` or empty.

#### Behavior

1. **Null/Empty Handling**: Returns an empty string if input is `null` or empty
2. **Normalization**: Removes accents/diacritics using Unicode normalization (Form D)
3. **Letter Mapping**: Maps A-Z to NATO phonetic words (case-insensitive)
4. **Non-Letter Preservation**: Digits, punctuation, and other characters are preserved as-is
5. **Whitespace**: Whitespace characters are preserved as tokens
6. **Separator**: All tokens are joined using the specified separator

#### Examples

```csharp
using NATOAlphabet;

// Basic usage
"NATO".ToNato(); 
// Returns: "November Alpha Tango Oscar"

// With numbers and punctuation
"ABC123".ToNato(); 
// Returns: "Alpha Bravo Charlie 1 2 3"

// With accents
"Café".ToNato(); 
// Returns: "Charlie Alpha Foxtrot Echo"

// Custom separator
"AB".ToNato("|"); 
// Returns: "Alpha|Bravo"

// Null/empty handling
((string?)null).ToNato(); 
// Returns: ""

"".ToNato(); 
// Returns: ""
```

## NATO Alphabet Mapping

The following table shows the complete mapping from letters to NATO phonetic words:

| Letter | NATO Word |
|--------|-----------|
| A | Alpha |
| B | Bravo |
| C | Charlie |
| D | Delta |
| E | Echo |
| F | Foxtrot |
| G | Golf |
| H | Hotel |
| I | India |
| J | Juliett |
| K | Kilo |
| L | Lima |
| M | Mike |
| N | November |
| O | Oscar |
| P | Papa |
| Q | Quebec |
| R | Romeo |
| S | Sierra |
| T | Tango |
| U | Uniform |
| V | Victor |
| W | Whiskey |
| X | Xray |
| Y | Yankee |
| Z | Zulu |

## Implementation Details

### Accent Normalization

The library uses Unicode normalization (FormD) to decompose accented characters into their base characters and combining diacritical marks. The diacritical marks (NonSpacingMark category) are then filtered out, leaving only the base character for mapping.

**Example:**
```
'É' → (FormD) → 'E' + combining acute accent
    → (filter NonSpacingMark) → 'E'
    → (map) → "Echo"
```

### Performance Characteristics

- **Time Complexity**: O(n) where n is the length of the input string
- **Space Complexity**: O(n) for the normalized string and token list
- **Dictionary Lookup**: O(1) for NATO word mapping

### Thread Safety

The `ToNato` extension method is thread-safe. The internal NATO alphabet mapping dictionary is read-only and can be safely accessed from multiple threads.

## Target Frameworks

NATOAlphabet supports the following target frameworks:

- **.NET Standard 2.0**: Compatible with .NET Framework 4.6.1+, .NET Core 2.0+, and .NET 5+
- **.NET 8.0**: Optimized for the latest .NET runtime
