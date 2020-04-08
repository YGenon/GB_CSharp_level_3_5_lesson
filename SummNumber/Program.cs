using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SummNumber
{
    class Program
    {
        private static object lockObject = new object();
        
        
        static long j = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                Thread thread = new Thread(Factorial);
                thread.Start();
            }
            Console.ReadKey();
        }

        static void Factorial()
        {
            lock (lockObject)
            {
                ++j;
                long rezult = 0;
                long count = 0;
                Console.WriteLine();
                Console.Write("Сумма чисел до числа " + (j-1) + " : ");

                for (long i = 0; i < j; i++)
                {
                    rezult = rezult + i;
                    count++;
                    if (count < j) Console.Write(  i + " + " );                    
                    if (count == j)Console.Write(i + " = " + rezult);
                }           
                

            }

        }
    }
}
