using System;



namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char avatar = 'P';

            for (int i = 1; i <= 100; i++) //<-- shortcut
                Console.WriteLine("MiniGame");
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadKey();
            bool gameOver = false;
            while (gameOver != true)
            {
             //....

            // turn states
            }
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.W)
            {
                Console.WriteLine(avatar);
                //if (y < 0) y = 0;
                // WASD controls 
                // [y,x]
                // y++;
                // x = x -1;
            }

            //KNOWLEDGE
        }
    }
}