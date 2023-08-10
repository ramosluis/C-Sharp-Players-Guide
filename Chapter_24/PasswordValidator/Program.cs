PasswordValidator password = new PasswordValidator("");

while (true)
{
    Console.Clear();
    Console.Write("Enter a password (0 to quit): ");
    password.Password = Console.ReadLine();

    if (password.Password.Equals("0")) break;

    if (password.ValidPassword())
        Console.WriteLine("Valid password.");
    else
        Console.WriteLine("Invalid password.");
    Console.ReadLine();
}


public class PasswordValidator
{
    public string Password { get; set; }

    public PasswordValidator (string password)
    {
        Password = password;
    }

    public bool ValidPassword ()
    {
        if (Password.Length < 6 || Password.Length > 13) return false;
        if (!CharacterChecker()) return false;

        return true;
    }

    private bool CharacterChecker()
    {
        bool hasUpper = false, hasLower = false, hasNumber = false;

        foreach (char character in Password)
        {
            if (char.IsUpper(character)) hasUpper = true;
            if (char.IsLower(character)) hasLower = true;
            if (char.IsDigit(character)) hasNumber = true;

            if (character == 'T' || character == '&') return false;
        }
        return hasUpper & hasLower & hasNumber;
    }
}