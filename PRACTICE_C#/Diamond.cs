using System;
using System.Collections.Generic;
using System.Text;

namespace PRACTICE_C_
{
    public class Diamond
    {
         public static void Main(string[] args)
         {
             for (int i = 1; i <= 8; i++)
             {
                 for (int j = i; j <= 7; j++)
                 {
                     Console.Write(" ");
                 }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                //for (int l = 2; l <= i; l++)
                // {
                //     Console.Write("*");
                // }
                Console.WriteLine();

             }

             //half inverted pyramid
             //for (int i = 2; i <= 8; i++)
             //{
             //    for (int j = 2; j <= i; j++)
             //    {
             //        Console.Write(" ");
             //    }
             //    for (int k = i; k <= 8; k++)
             //    {
             //        Console.Write("*");
             //    }
             //    for (int l = i; l <= 7; l++)
             //    {
             //        Console.Write("*");
             //    }

             //    Console.WriteLine();
             //}
             Console.ReadLine();
         }
     }
    }

