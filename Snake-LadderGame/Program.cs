using System;

namespace Snake_LadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            int player1 = 0;
            while (player1<99)
            {
                Random random = new Random();
                int dice = random.Next(0, 7);
                int snake = random.Next(0, 7);
                player1 = Method.PositionCheck(dice, player1, snake);

                Console.WriteLine("dice " + dice);

                Console.WriteLine("snake " + snake);
            }
        }
    }
}
