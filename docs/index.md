# NATOAlphabet

Convert letters in a string to their NATO phonetic alphabet equivalents.

## Features

- **Simple API**: Just one extension method to convert strings to NATO phonetic alphabet
- **Accent Handling**: Automatically normalizes accented characters (e.g., 'É' → 'E')
- **Preserves Special Characters**: Non-letter characters are preserved as separate tokens
- **Customizable Separator**: Use any separator between NATO words
- **Multi-Target Support**: Works with .NET Standard 2.0 and .NET 8.0

## Quick Example

```csharp
using NATOAlphabet;

Console.WriteLine("Hello!".ToNato()); 
// Output: "Hotel Echo Lima Lima Oscar !"
```

## Installation

Install the package via NuGet:

```bash
dotnet add package NATOAlphabet
```

Or via the Package Manager Console:

```powershell
Install-Package NATOAlphabet
```

## Getting Started

Check out the [Getting Started](getting-started.md) guide to learn more about using NATOAlphabet in your projects.

For detailed information about the API, see the [API Reference](api-reference.md).
