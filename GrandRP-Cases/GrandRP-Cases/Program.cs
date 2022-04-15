using System;

namespace GrandRP_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grand-Coin input
            int grandCoinInput = 0;
            //Costs,minimum output, guaranteed bonus
            int[] fivePointCase = { 5, 50000, 200000 };
            //20P-Box
            int[] twentyPointCase = { 20, 300000, 1500000 };


            Console.WriteLine("Enter available Grand-Coins:");
            try
            {
                grandCoinInput = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                return;
            }

            //output of the earned money
            Console.WriteLine($"Die Kisten für 5 GrandCoins: {Calc(grandCoinInput, fivePointCase)}");
            Console.WriteLine($"Die Kisten für 20 GrandCoins: {Calc(grandCoinInput, twentyPointCase)}");
        }

        static int Calc(int aInput, int[] aCase)
        {
            int result = 0;
            int counter = 0;

            int amountOfCases = aInput / aCase[0];
            for (int i = 1; i <= amountOfCases; i++)
            {
                result += aCase[1];
                counter++;
                if (counter == 10)
                {
                    result += aCase[2];
                    counter = 0;
                }
            }
            return result;
        }
    }
}
