using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class PrintBoard
    {
        public void Print(bool[,] b)
        {
            int width = b.GetLength(0);
            int height = b.GetLength(1);

            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());


            Thread.Sleep(300);

        }
    }
}