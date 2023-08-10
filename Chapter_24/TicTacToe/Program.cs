UserInterface ui = new UserInterface();
ui.Start();

public class TicTacToe
{
    public string[] Marks { get; set; }
    public TicTacToe()
    {
        Marks = new string[10];
        for (int i = 0; i < Marks.Length; i++)
        {
            Marks[i] = "";
        }
    }

    public void DrawBoard()
    {
        Console.WriteLine(@$"
 {Marks[7]} | {Marks[8]} | {Marks[9]} 
---+---+---
 {Marks[4]} | {Marks[5]} | {Marks[6]} 
---+---+---
 {Marks[1]} | {Marks[2]} | {Marks[3]} ");
    }

    public bool MarkSpace(int selection, string player)
    {
        if (selection > 0 && selection < 10 && Marks[selection] == "")
        {
            Marks[selection] = player;
            return true;
        }
        else
            Console.WriteLine("Invalid move, square is not empty.");
        return false;
    }

    public string CheckForWinner()
    {
        bool allMarked = true;

        if (Marks[1].Equals(Marks[2]) && Marks[2].Equals(Marks[3]))
            return Marks[1];
        else if (Marks[4].Equals(Marks[5]) && Marks[5].Equals(Marks[6]))
            return Marks[4];
        else if (Marks[7].Equals(Marks[8]) && Marks[8].Equals(Marks[9]))
            return Marks[7];
        else if (Marks[7].Equals(Marks[4]) && Marks[4].Equals(Marks[1]))
            return Marks[7];
        else if (Marks[8].Equals(Marks[5]) && Marks[5].Equals(Marks[2]))
            return Marks[8];
        else if (Marks[9].Equals(Marks[6]) && Marks[6].Equals(Marks[3]))
            return Marks[9];
        else if (Marks[7].Equals(Marks[5]) && Marks[5].Equals(Marks[3]))
            return Marks[7];
        else if (Marks[9].Equals(Marks[5]) && Marks[5].Equals(Marks[1]))
            return Marks[9];
        else
        {
            for(int i = 1; i < Marks.Length; i++)
            {
                if (Marks[i].Equals("")) allMarked = false;
            }
            if (allMarked) return "Tie";
        }
        return "";
    }
}

public class UserInterface
{
    private TicTacToe game;
    private string Player { get; set; }
    public UserInterface() 
    {
        game = new TicTacToe();
        Player = "X";
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"It is {Player}'s turn.");
            game.DrawBoard();
            while (true)
            {
                Console.Write("What square do you want to play in? ");
                int selection = Convert.ToInt32(Console.ReadLine());
                if (game.MarkSpace(selection, Player))
                    break;
            }
            string winner = game.CheckForWinner();
            if(winner.Equals(Player))
            {
                Console.Clear();
                game.DrawBoard();
                Console.WriteLine($"{Player} has won!");
                break;
            }
            else if (winner.Equals("Tie"))
            {
                Console.Clear();
                game.DrawBoard();
                Console.WriteLine("This game has ended in a tie.");
                break;
            }
            else
            {
                UpdatePlayer();
            }
        }
        Console.ReadLine();
    }

    private void UpdatePlayer()
    {
        if (Player == "X")
            Player = "O";
        else
            Player = "X";
    }
}