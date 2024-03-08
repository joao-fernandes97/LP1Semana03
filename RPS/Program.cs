using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameStatus result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(string player1, string player2)
        {
            GameStatus result;
            GameItem p1Hand = (GameItem)Enum.Parse(typeof(GameItem), player1);
            GameItem p2Hand = (GameItem)Enum.Parse(typeof(GameItem), player2);
            if (player1 == player2)
            {
                result = GameStatus.Draw; // Draw
            }
            if (((p1Hand == GameItem.Rock) && (p2Hand == GameItem.Scissors)) ||
                ((p1Hand == GameItem.Scissors) && (p2Hand == GameItem.Paper)) ||
                ((p1Hand == GameItem.Paper) && (p2Hand == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                result = GameStatus.Player2Wins; // Player 2 wins
            }
            return result;
        }
    }
}
