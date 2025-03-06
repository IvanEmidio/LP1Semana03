using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            GameItem game1 = (GameItem)Enum.Parse(typeof(GameItem), player1);
            GameItem game2 = (GameItem)Enum.Parse(typeof(GameItem), player2);

            GameStatus result = 0;

            if (game1 == game2)
            {
                result = GameStatus.Draw;

                return (int)result; // Draw
            }
            if (((game1 == GameItem.Rock) && (game2 == GameItem.Scissor)) ||
                ((game1 == GameItem.Scissor) && (game2 == GameItem.Paper)) ||
                ((game1 == GameItem.Paper) && (game2 == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins;
                return (int)result; // Player 1 wins
            }
            else
            {   
                result = GameStatus.Player2Wins;
                return (int)result; // Player 2 wins
            }
        }
    }
}
