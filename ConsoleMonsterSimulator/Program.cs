using ConsoleMonsters;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "MonsterAttack"; // Set the console title
        Console.CursorVisible = false; // Hide the cursor for better UI
        Game game = new Game(); // Create new Game class
        game.GameLoop(); // Run the main game logic
    }
}