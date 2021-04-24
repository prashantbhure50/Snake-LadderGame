using System;

namespace Snake_LadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            int player1 = 0;
            int player2 = 0;
            int diceCount = 0;
            int turn =1000;
           while (true)
            {
                Random random = new Random();
                int  dice = random.Next(0, 7);
                int snake = random.Next(0, 7);
                if (turn % 2 == 0)
                {
                     player1 = Method.PositionCheck(dice, player1, snake);
                }
                else
                {
                     player2 = Method.PositionCheck(dice, player1, snake);
                }
                diceCount++;
                Console.WriteLine("dice Position " + dice);
                if (player1 > 99)
                {
                    Console.WriteLine("player 1 WON");
                    break;
                }
                else if (player2 > 99)
                {
                    Console.WriteLine("player 2 WON");
                    break;
                }
                turn++;
            }
            Console.WriteLine("Player1 "+player1);
            Console.WriteLine("Player2 " + player2);
           Console.WriteLine("total no of time played "+diceCount);
           
        }
    }
}
