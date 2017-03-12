using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float input;

            for (int i = 0; i < 7; i++)
            {
                Console.Write("請輸入數字: ");

                try
                {
                    input = float.Parse(Console.ReadLine());
                    Console.WriteLine(input.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}