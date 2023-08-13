Sword original = new Sword(SwordMaterial.Iron, Gemstone.None, 100, 20);
Sword firstCopy = original with { Material = SwordMaterial.Steel, Stone = Gemstone.Sapphire };
Sword secondCopy = original with { Length = 75, Width = 10};

Console.WriteLine($@"Original: {original}
First copy: {firstCopy}
Second copy: { secondCopy}");

public enum SwordMaterial
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
}

public enum Gemstone
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None
}

public record Sword(SwordMaterial Material, Gemstone Stone, int Length, int Width);