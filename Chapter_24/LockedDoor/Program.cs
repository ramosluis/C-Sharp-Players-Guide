Console.Write("Enter a passcode: ");
string passcode = Console.ReadLine();

Door door = new Door(passcode);

while(true)
{
    Console.Clear();
    Console.Write(@$"What would you like to do with the door?
1 - Open
2 - Close
3 - Lock
4 - Unlock
5 - Change Passcode
0 - Quit

Door is currently {door.State}

> ");

    int answer = Convert.ToInt32(Console.ReadLine());
    if (answer == 0)
        break;

    switch (answer)
    {
        case 1:
            door.OpenDoor();
            break;
        case 2:
            door.CloseDoor();
            break;
        case 3:
            door.LockDoor();
            break;
        case 4:
            Console.Write("Enter passcode to unlock door: ");
            passcode = Console.ReadLine(); 
            door.UnlockDoor(passcode);
            break;
        case 5:
            door.ResetPasscode();
            break;
    }

    Console.ReadLine();
}


public class Door
{
    private string Passcode { get; set; }
    public DoorState State { get; private set; }

    public Door (string passcode)
    {
        Passcode = passcode;
        State = DoorState.Locked;
    }

    public void CloseDoor()
    {
        if (State == DoorState.Open)
        {
            State = DoorState.Closed;
            Console.WriteLine("Door closed successfully.");
            return;
        }

        Console.WriteLine("Invalid transition");
    }

    public void OpenDoor()
    {
        if(State == DoorState.Closed)
        {
            State = DoorState.Open;
            Console.WriteLine("Door opened successfully.");
            return;
        }

        Console.WriteLine("Invalid transition");
    }

    public void LockDoor()
    {
        if (State == DoorState.Closed)
        {
            State = DoorState.Locked;
            Console.WriteLine("Door locked successfully.");
            return;
        }

        Console.WriteLine("Invalid transition");
    }

    public void UnlockDoor(string passcode)
    {
        if (State == DoorState.Locked)
        {
            if (passcode.Equals(Passcode))
            {
                State = DoorState.Closed;
                Console.WriteLine("Door unlocked successfully.");
                return;
            }

            Console.WriteLine("Incorrect passcode.");
            return;
        }

        Console.WriteLine("Invalid transition");
    }

    public void ResetPasscode()
    {
        Console.Write("Enter current passcode: ");
        string passcode = Console.ReadLine();

        if (passcode.Equals(Passcode))
        {
            Console.Write("Enter new passcode: ");
            Passcode = Console.ReadLine();
            Console.WriteLine("Passcode reset complete!");
            return;
        }

        Console.WriteLine("Incorrect passcode.\nPasscode reset failed.");
    }
}

public enum DoorState
{
    Open,
    Closed,
    Locked
}