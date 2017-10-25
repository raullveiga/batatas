using System;

namespace CalculoCPF
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite os numeros");
            string cpf = Console.ReadLine();

            string calcCpf = cpf.Substring(0,9);

            int[] p = {10,9,8,7,6,5,4,3,2};
            int[] p2 = {10,9,8,7,6,5,4,3,2};

            int sum =0;
            int resto =0;

            for(int i=0;i>calcCpf.Length;i++)
                sum += Int16.Parse(calcCpf[i].toString())*p[i];

                            

            

            
           

        }
    }
}
