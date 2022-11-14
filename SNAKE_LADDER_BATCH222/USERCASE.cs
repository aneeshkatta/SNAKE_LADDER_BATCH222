using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE_LADDER_BATCH222
{
    internal class USERCASE
    {
        static void Main()
        {
            Console.WriteLine("This is a two Player game.");
            int player1Position = 0;
            int player2Position = 0;
            Console.WriteLine("Player 1 position is: " + player1Position);
            Console.WriteLine("Player 2 position is: " + player2Position);

            while (player1Position != 100 && player2Position != 100)
            {
                //player1
                Console.Write("Player 1 roll. ");
                player1Position += playerRoll(player1Position);
                if (player1Position < 0)
                {
                    player1Position = 0;
                }
                Console.WriteLine("Player 1 position is: " + player1Position);

                if (player1Position == 100)
                {
                    Console.WriteLine("Player 1 win the game.");
                    break;
                }

                //player2
                Console.Write("Player 2 roll. ");
                player2Position += playerRoll(player2Position);
                if (player2Position < 0)
                {
                    player2Position = 0;
                }
                Console.WriteLine("Player 2 position is: " + player2Position);
                if (player2Position == 100)
                {
                    Console.WriteLine("Player 2 win the game.");
                    break;
                }
            }
        }

        public static int playerRoll(int playerPosition)
        {
            int position = 0;
            int playTimes = 1;
            Random random = new Random();
            const int Noplay = 0;
            const int ladder = 1;
            const int snake = 2;

            while (playTimes != 0)
            {
                int roll = random.Next(1, 7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case Noplay:
                        //no play
                        Console.Write("Player choose not to play. ");
                        playTimes--;
                        break;
                    //ladder
                    case ladder:
                        if (playerPosition + position > 100)
                        {
                            Console.Write("Player choose not to play. ");
                            playTimes--;
                        }
                        else
                        {
                            position += roll;
                            Console.Write("Player choose the ladder with {0} roll. ", roll);
                            playTimes = 1;
                        }

                        break;
                    //snake
                    case snake:
                        position -= roll;
                        Console.Write("Player choose the snake with {0} roll. ", roll);
                        playTimes--;

                        break;
                }

            }

            return position;
        }
    }
}
