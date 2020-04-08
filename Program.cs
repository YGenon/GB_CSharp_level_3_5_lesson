using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Factorial
{
    
    class Program
    {   
        private static object lockObject = new object();
        //static int number = 0;
        static long x = 1;
        static long j = 0;

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
                j++;
                Console.WriteLine( j + "! = " + j * x, x = j * x) ;
            }
            
        }
    }
}
