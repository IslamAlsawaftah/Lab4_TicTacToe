using System;
using Lab04_TicTacToe.Classes;
namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe");
            StartGame();
        }

        static void StartGame()
        {
            // TODO: Setup your game. Create a new method that creates your players and instantiates the game class. Call that method in your Main method.
            // You are requesting a Winner to be returned, Determine who the winner is output the celebratory message to the correct player. If it's a draw, tell them that there is no winner. 
            Console.Write("Please enter player 1 name: ");
            string player1 = Console.ReadLine();
            Console.Write("Please enter Player 2 name: ");
            
            string player2 = Console.ReadLine();
            Player _player1 = new Player() //create player 1
            {
                Name = player1,
                Marker = "x",
                IsTurn = true
            };
            Player _player2 = new Player() //create player 2
            {
                Name = player2,
                Marker = "o",
                IsTurn = false
            };
            Game TGame = new Game(_player1, _player2); // instantiates the game class
            Player winner = TGame.Play(); // play game and determin winner
            if (winner == null)
            {
                Console.WriteLine("it's a draw, there is no winner"); // If it's a draw
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("congrats, " + winner.Name + " you won!!!!"); // celebratory message to the correct player
            }
        }


    }
}
