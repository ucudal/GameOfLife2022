using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PrintBoard print = new PrintBoard();
            Game gamelogic = new Game();
            string url = "../../assets/board.txt";
            board.BuildBoard(url);
            bool[,] board2 = board.GetBoard;
            

            while (true)
            {
               
                print.Print(board2);
                board2 = gamelogic.GameLogic(board2);

                
            }

        }
    }
}
