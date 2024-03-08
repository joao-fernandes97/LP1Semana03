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
            if (player1 == player2)
            {
                result = GameStatus.Draw; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
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
