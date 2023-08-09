Card[] deck = new Card[56];
int index = 0;
for (int i = 0; i < Enum.GetNames(typeof(CardColor)).Length; i++)
{
    for (int j = 0; j < Enum.GetNames(typeof(CardRank)).Length; j++)
    {
        deck[index] = new Card((CardColor)i, (CardRank)j);
        index++;
    }
}

foreach(Card card in deck)
{
    Console.WriteLine($"The {card.Color} {card.Rank}");
}

public class Card
{
    public CardColor Color { get; init; }
    public CardRank Rank { get; init; }

    public Card() : this(CardColor.Green, CardRank.Ampersand) { }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public void CardType()
    {
        if (Rank < CardRank.Dollar)
        {
            Console.WriteLine("This is a number card.");
            return;
        }

        Console.WriteLine("This is a symbol card.");
    }

}

public enum CardColor
{
    Red,
    Green,
    Blue,
    Yellow
}

public enum CardRank
{
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Dollar,
    Percent,
    Caret,
    Ampersand
}