# Getting Started

This guide will help you get started with NATOAlphabet in your .NET projects.

## Installation

### Using .NET CLI

```bash
dotnet add package NATOAlphabet
```

### Using Package Manager Console

```powershell
Install-Package NATOAlphabet
```

### Using Visual Studio

1. Right-click on your project in Solution Explorer
2. Select "Manage NuGet Packages..."
3. Search for "NATOAlphabet"
4. Click "Install"

## Basic Usage

The library provides a single extension method `ToNato()` that converts strings to their NATO phonetic alphabet representation:

```csharp
using NATOAlphabet;

// Basic conversion
string result = "ABC".ToNato();
Console.WriteLine(result); // "Alpha Bravo Charlie"
```

## Behavior

### Letter Conversion

All letters A-Z (case-insensitive) are converted to their NATO phonetic alphabet equivalents:

```csharp
"NATO".ToNato(); // "November Alpha Tango Oscar"
"abc".ToNato();  // "Alpha Bravo Charlie"
```

### Accent Normalization

Accented characters are automatically normalized before conversion:

```csharp
"Café".ToNato(); // "Charlie Alpha Foxtrot Echo"
```

### Special Characters

Non-letter characters (digits, punctuation, symbols) are preserved as separate tokens:

```csharp
"Hi!".ToNato();      // "Hotel India !"
"Pwd123!".ToNato();  // "Papa Whiskey Delta 1 2 3 !"
"ABC123".ToNato();   // "Alpha Bravo Charlie 1 2 3"
```

### Whitespace

Whitespace characters are treated as non-letter characters and preserved:

```csharp
"A B".ToNato();  // "Alpha  Bravo"
```

### Custom Separator

By default, tokens are separated by a single space. You can provide a custom separator:

```csharp
"AB".ToNato("|");    // "Alpha|Bravo"
"AB".ToNato(" - ");  // "Alpha - Bravo"
"ABC".ToNato("");    // "AlphaBravoCharlie"
```

## Advanced Examples

### Processing User Input

```csharp
using NATOAlphabet;

Console.Write("Enter a message: ");
string? input = Console.ReadLine();
string nato = input.ToNato();
Console.WriteLine($"NATO: {nato}");
```

### Formatting Output

```csharp
using NATOAlphabet;

string message = "SOS";
string formatted = message.ToNato(" | ");
Console.WriteLine(formatted); 
// "Sierra | Oscar | Sierra"
```

### Handling Null or Empty Strings

```csharp
using NATOAlphabet;

string? nullString = null;
string emptyString = "";

Console.WriteLine(nullString.ToNato()); // ""
Console.WriteLine(emptyString.ToNato()); // ""
```

## Next Steps

- Check out the [API Reference](api-reference.md) for detailed documentation
- View the [NATO Phonetic Alphabet mapping](api-reference.md#nato-alphabet-mapping)
