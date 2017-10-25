using System;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name;
            int idade;
            Console.Clear();
            Console.WriteLine("Programa de Boas Vindas");
            Console.Write("Digite seu nome:");
            name=Console.ReadLine();
            Console.WriteLine("Olá "+ name.ToUpper()); 
            Console.Write("Digite a sua idade:");  
            idade = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Você tem: "+idade+" anos."); 


        }
    }
}
