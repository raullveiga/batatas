using System;

namespace while1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =1, n;
            
            Console.Write("Digite N: ");
            n = Convert.ToInt32(Console.ReadLine());
            while(x<=10){
                Console.WriteLine("{0}x{1}={2}",n,x,n*x++);
            }
            
        }
    }
}
