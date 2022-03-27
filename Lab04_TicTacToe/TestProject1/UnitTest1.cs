using System;
using Xunit;
using Lab04_TicTacToe.Classes;
namespace TestProject1
{
    public class UnitTest1
    {
        static Player player1 = new Player
        {
            Name = "islam",
            Marker = "x",
            IsTurn = true
        };

        static Player player2 = new Player
        {
            Name = "aseel",
            Marker = "o",
            IsTurn = false
        };
        Game game = new Game(player1,player2);

        //test for winners
        [Fact]
        public void TestForWinners()
        {
            string[,] Winner = new string[,]
           {
                {"x", "x", "x"},
                {"o", "o", "x"},
                {"x", "o", "o"},
           };
            game.Board.GameBoard = Winner;
            Assert.True(game.CheckForWinner(game.Board));

        }
        // Test that there is a switch in players between turns
        [Fact]
        public void TestSwitchPlayer()
        {
            game.SwitchPlayer();
            Assert.True(player2.IsTurn);
        }
        //Test to confirm that the position the player inputs correlates to the correct index of the array
        [Fact]
        public void TestForPosition()
        {
             Position pos = new Position(1,0);
             Assert.Equal(pos.Row, Player.PositionForNumber(4).Row);
        }
        // “unique” test of your own
        [Fact]
        public void TestForNoWinners()
        {
            string[,] Winner = new string[,]
           {
                {"x", "o", "x"},
                {"o", "x", "o"},
                {"o", "x", "o"},
           };
            game.Board.GameBoard = Winner;
            Assert.False(game.CheckForWinner(game.Board));
        }
    }
    }
