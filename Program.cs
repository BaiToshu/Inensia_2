using System;

namespace Inensia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the gross salary in IDR:");
            long gross = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (gross <= 1000) Console.WriteLine("The net salary after taxes is: {0} IDR",gross);
            else 
            {
                long income=0, social=0;
                if (gross > 3000)
                {
                    income = (gross - 1000) / 10;
                    social = 2000 * 15 / 100;
                    Console.WriteLine("The net salary after taxes is: {0} IDR", gross - income - social);
                }
                else
                {
                    income = (gross - 1000) / 10;
                    social = (gross - 1000) * 15 / 100;
                    Console.WriteLine("The net salary after taxes is: {0} IDR", gross - income - social);
                }
            }
        }
    }
}
