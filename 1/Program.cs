using System;
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=1.0;
            int amount=1;
            bool condition = true,parse;
            while (condition)
            {
                Console.WriteLine("Введите колличество попыток ввода");
                parse = Int32.TryParse(Console.ReadLine(), out amount);
                if (amount > 0 && amount<=100 && parse == true)
                {
                    condition = false;
                }
            }
            for (int i=0;i<amount;i++)
            {
                condition = true;
                parse = false;
                while (condition)
                {
                    Console.WriteLine("Введите переменную x");
                    parse = Double.TryParse(Console.ReadLine(), out x);
                    if (x >= -1000 && x <= 1000 && parse == true)
                    {
                        condition = false;
                    }
                }
                double result = Math.Pow(x, 4) + 1.2 * Math.Pow(x, 3) - 20 * Math.Pow(x, 2) + 123.456;
                string OutputResult = String.Format("{0:f3}", result);
                Console.WriteLine(OutputResult);
            }
        }
    }
}
