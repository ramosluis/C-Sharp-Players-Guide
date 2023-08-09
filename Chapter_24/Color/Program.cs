Color colorPurple = new Color();
Color colorYellow = Color.Yellow;

Console.WriteLine(@$"Purple color channels:
Red  Green  Blue
{colorPurple.RedChannel}  {colorPurple.GreenChannel}      {colorPurple.BlueChannel}

Yellow color channels:
Red  Green  Blue
{colorYellow.RedChannel}  {colorYellow.GreenChannel}    {colorYellow.BlueChannel}");

public class Color
{
    public byte RedChannel { get; set; }
    public byte GreenChannel { get; set; }
    public byte BlueChannel { get; set; }

    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Red { get; } = new Color(255, 0, 0);
    public static Color Orange { get; } = new Color(255, 165, 0);
    public static Color Yellow { get; } = new Color(255, 255, 0);
    public static Color Green { get; } = new Color(0, 128, 0);
    public static Color Blue { get; } = new Color(0, 0, 255);
    public static Color Purple { get; } = new Color(128, 0, 128);

    public Color() : this(128, 0, 128) { }

    public Color(byte red, byte green, byte blue)
    {
        RedChannel = red;
        GreenChannel = green;
        BlueChannel = blue;
    }
}