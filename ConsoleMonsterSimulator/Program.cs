internal class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "Monster Attack";
        Console.CursorVisible = false;
        MonsterAttack(); // RUN GAME
    }

    public static void MonsterAttack()
    {
        Console.Clear();
        PrintTitle();
        Console.WriteLine("Press any key to continue..\n");
        Console.ReadKey();
        Console.Clear();
        do
        {
    
        } while (true);
    }
    public static void PrintTitle()
    {
        Console.WriteLine("\n\n");
        Console.WriteLine("\r\n  __  __  ____  _   _  _____ _______ _____  ______ _____  \r\n |  \\/  |/ __ \\| \\ | |/ ____|__   __|  __ \\|  ____|  __ \\ \r\n | \\  / | |  | |  \\| | (___    | |  | |__) | |__  | |__) |\r\n | |\\/| | |  | | . ` |\\___ \\   | |  |  _  /|  __| |  _  / \r\n | |  | | |__| | |\\  |____) |  | |  | | \\ \\| |____| | \\ \\ \r\n |_|  |_|\\____/|_|_\\_|_____/  _|_|_ |_|__\\_\\______|_|  \\_\\\r\n     /\\|__   __|__   __|/\\   / ____| |/ /                 \r\n    /  \\  | |     | |  /  \\ | |    | ' /                  \r\n   / /\\ \\ | |     | | / /\\ \\| |    |  <                   \r\n  / ____ \\| |     | |/ ____ \\ |____| . \\                  \r\n /_/    \\_\\_|     |_/_/    \\_\\_____|_|\\_\\                 \r\n                                                          \r\n                                                          \r\n"); // TITEL STRING
        Console.WriteLine("\n\n");
    }
    public static void PrintOptions()
    {

    }
}

