# NATOAlphabet

Convert letters in a string to their NATO phonetic alphabet equivalents.

## Install

```bash
dotnet add package NATOAlphabet
```

## Usage

```csharp
using NATOAlphabet;

Console.WriteLine("Hello!".ToNato()); // "Hotel Echo Lima Lima Oscar !"
```

## Behavior

- Letters A-Z are converted to NATO words.
- Input is normalized to remove accents/diacritics before mapping.
- Non-letter characters (digits, punctuation) are preserved as separate tokens.
- Default separator is a single space. You can provide a custom separator.

## Build and Pack

```bash
dotnet build -c Release
# NuGet package generated during build
```
