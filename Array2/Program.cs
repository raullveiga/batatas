using System;

namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {

            int q=Convert.ToInt32(Console.ReadLine());

            int[] n = new int[q-1];

            for(int i=0;i<n.Length;i++)
                n[i]=Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n.Length;i++)
                n[0]+=n[i];
                
            Console.WriteLine("soma= {0} \nmedia= {1}",n[0],n[0]/n.Length-1);


        }
    }
}
