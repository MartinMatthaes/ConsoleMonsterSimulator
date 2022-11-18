using ConsoleMonsters;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "MonsterAttack";
        Console.CursorVisible = false;
        //Create new game and run GameLoop function
        Game game = new();
        game.GameLoop();
    }
}