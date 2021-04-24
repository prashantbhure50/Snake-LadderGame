using System;

namespace Snake_LadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            int player1 = 0;
            int diceCount = 0;
           
            while (player1<99)
            {
                Random random = new Random();
              int  dice = random.Next(0, 7);
                 int snake = random.Next(0, 7);
                player1 = Method.PositionCheck(dice, player1, snake);
                diceCount++;
                Console.WriteLine("dice Position " + dice);              
            }
            Console.WriteLine("Player "+player1);
            Console.WriteLine("total no of time played "+diceCount);
           
        }
    }
}
