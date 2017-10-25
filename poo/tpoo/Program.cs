using System;

namespace tpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc n = new Calc();
            double[] p = {2,2,2};
            int i=2;
            int c=3;

            Console.Write(n.Soma(p).ToString(),n.Media(p),n.Ex(i,c));
            

        }
    }
}
