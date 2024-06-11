namespace AstraEngine.Canvas2D;

/// <summary>Represents an RGBA color</summary>
public record struct Color(byte R, byte G, byte B, byte A)
{
    /// <summary>
    /// Converts a string into a color
    /// </summary>
    /// <param name="input">Input string</param>
    /// <returns>Color</returns>
    public static Color FromString(string input)
    {
        Color color = input switch
        {
            "Black" => Black,
            "White" => White,
            "Red" => Red,
            "Green" => Green,
            "Blue" => Blue,
            _ => new Color(0, 0, 0, 0)
        };
        return color;
    }
    /// <summary>Black</summary>
    public readonly static Color Black = new(0, 0, 0, 255);
    /// <summary>White</summary>
    public readonly static Color White = new(255, 255, 255, 255);
    /// <summary>Red</summary>
    public readonly static Color Red = new(255, 0, 0, 255);
    /// <summary>Green</summary>
    public readonly static Color Green = new(0, 255, 0, 255);
    /// <summary>Blue</summary>
    public readonly static Color Blue = new(0, 0, 255, 255);
}