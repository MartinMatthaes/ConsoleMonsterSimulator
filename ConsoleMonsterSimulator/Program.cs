using ConsoleMonsters;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "MonsterAttack";
        Game game = new Game();
        game.GameLoop();
    }
}