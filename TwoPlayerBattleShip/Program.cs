using System;
using System.Security.Cryptography.X509Certificates;

namespace TwoPlayerBattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] a = new string[20, 20];

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    a[i,j] =  "O";
                }
            }

            a[5, 5] = "D";
            a[7, 5] = "R";
            a[0, 0] = "A";
            a[17, 14] = "T";

            Console.WriteLine("Enter coordinates to change: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            string value = "testing";

            a[x, y] = value;


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(a[i, j] + "  ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
           
        }
    }
}
