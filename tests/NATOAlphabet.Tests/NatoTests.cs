using Xunit;
using NATOAlphabet;

namespace NATOAlphabet.Tests;

public class NatoTests
{
    [Theory]
    [InlineData("NATO", "November Alpha Tango Oscar")]
    [InlineData("ABC", "Alpha Bravo Charlie")]
    [InlineData("ABC123", "Alpha Bravo Charlie 1 2 3")]
    [InlineData("Pwd123!", "Papa Whiskey Delta 1 2 3 !")]
    [InlineData("Hi!", "Hotel India !")]
    [InlineData("Café", "Charlie Alpha Foxtrot Echo")]
    [InlineData("--X Y--", "- - Xray  Yankee - -")]
    [InlineData("", "")]
    [InlineData(null, "")]
    public void ToNato_Basic(string? input, string expected)
    {
        var actual = input.ToNato();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void ToNato_CustomSeparator()
    {
        var s = "AB";
        Assert.Equal("Alpha|Bravo", s.ToNato("|"));
    }
}
