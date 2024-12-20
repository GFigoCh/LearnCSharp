namespace MiniGame_Challenge;

class Program
{
    static Random randomizer = new Random();
    static int height = Console.WindowHeight - 1;
    static int width = Console.WindowWidth - 5;

    static int playerX = 0;
    static int playerY = 0;
    
    static int foodX = 0;
    static int foodY = 0;

    static string[] states = {"('-')", "(^-^)", "(x_x)"};
    static string[] foods = {"@@@@@", "$$$$$", "#####"};

    static string player = states[0];
    static int food = 0;
    static bool shouldExit = false;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;

        InitializeGame();
        while (!shouldExit)
        {
            if (TerminalResized())
            {
                Console.Clear();
                Console.WriteLine("Console was resized, program exiting...");
                break;
            }

            if (PlayerBuffed())
            {
                Move(nondirectionalTermination: true, movementSpeed: 3);
            }
            else
            {
                Move(nondirectionalTermination: true);
            }

            if (FoodConsumed())
            {
                ChangePlayer();
                ShowFood();

                if (PlayerStunned())
                {
                    FreezePlayer();
                }
            }
        }
    }

    static void InitializeGame()
    {
        Console.Clear();
        ShowFood();
        Console.SetCursorPosition(0, 0);
        Console.Write(player);
    }

    static bool PlayerStunned()
    {
        return player == states[2];
    }

    static bool PlayerBuffed()
    {
        return player == states[1];
    }

    static bool FoodConsumed()
    {
        return foodX == playerX && foodY == playerY;
    }

    static bool TerminalResized()
    {
        return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
    }

    static void ShowFood()
    {
        food = randomizer.Next(0, foods.Length);

        foodX = randomizer.Next(0, width - player.Length);
        foodY = randomizer.Next(0, height - 1);

        Console.SetCursorPosition(foodX, foodY);
        Console.Write(foods[food]);
    }

    static void ChangePlayer()
    {
        player = states[food];
        Console.SetCursorPosition(playerX, playerY);
        Console.Write(player);
    }

    static void FreezePlayer()
    {
        Thread.Sleep(1000);
        player = states[0];
    }

    static void Move(bool nondirectionalTermination = false, int movementSpeed = 1)
    {
        int lastX = playerX;
        int lastY = playerY;

        switch (Console.ReadKey(true).Key)
        {
            case ConsoleKey.UpArrow:
                playerY--;
                break;

            case ConsoleKey.DownArrow:
                playerY++;
                break;

            case ConsoleKey.LeftArrow:
                playerX -= movementSpeed;
                break;

            case ConsoleKey.RightArrow:
                playerX += movementSpeed;
                break;

            case ConsoleKey.Escape:
                shouldExit = true;
                break;

            default:
                shouldExit = nondirectionalTermination;
                break;
        }

        Console.SetCursorPosition(lastX, lastY);
        for (int i = 0; i < player.Length; i++)
        {
            Console.Write(' ');
        }

        if (playerX < 0)
        {
            playerX = 0;
        }
        else if (playerX >= width)
        {
            playerX = width;
        }

        if (playerY < 0)
        {
            playerY = 0;
        }
        else if (playerY >= height)
        {
            playerY = height;
        }

        Console.SetCursorPosition(playerX, playerY);
        Console.Write(player);
    }
}
