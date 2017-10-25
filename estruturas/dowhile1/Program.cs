using System;

namespace dowhile1
{
    class Program
    {
        static void Main(string[] args)
        {
             int x = 0;
            /*do{
            Console.WriteLine("Hello World!");
            }while(x>0); */

            do { 
                Console.WriteLine("O valor atual do aumento é de: " + x); 
                x ++; 
            } while (x < 1000000); 

        }
    }
}
