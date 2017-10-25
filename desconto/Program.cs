using System;

namespace desconto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nprod;
            double preco,taxa,vfinal;
            Console.Clear();
            Console.WriteLine("Programa de cáculo de desconto");
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Digite o nome do produto: ");
            nprod = Console.ReadLine();
            Console.Write("Digite o preço do produto: R$");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Digite a taxa de desconto: ");
            taxa = double.Parse(Console.ReadLine());

                vfinal = preco*(taxa/100);
            Console.Clear();
            Console.WriteLine("Nome do produto: "+nprod);
            Console.WriteLine("Valor do produto: R$"+preco);
            Console.WriteLine("Valor do desconto: R$"+vfinal);
            Console.WriteLine("O valor final é R$"+ (preco - vfinal));

            




        }
    }
}
