using System;

namespace acrescimo
{
    class Program
    {
        static void Main(string[] args)
        {
           string nprod;
            double preco,taxa,vfinal;
            Console.Clear();
            Console.WriteLine("Programa de cáculo de acréscimo ou desconto");
            Console.WriteLine("---------------------------------------------------------");
            Console.Write("Digite o nome do produto: ");
            nprod = Console.ReadLine();
            Console.Write("Digite o preço do produto: R$");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Digite A para acréscimo ou D para desconto: ");
switch (Console.ReadLine())
            {
                case "A":
                    Console.Write("Digite a taxa de acréscimo: ");
                     taxa = double.Parse(Console.ReadLine());

                      vfinal = preco*(taxa/100);
            Console.Clear();
            Console.WriteLine("Nome do produto: "+nprod);
            Console.WriteLine("Valor do produto: R$"+preco);
            Console.WriteLine("Valor do acréscimo: R$"+vfinal);
                    preco=preco+vfinal;
                    break;
                case "D":
                    Console.Write("Digite a taxa de desconto: ");
            taxa = double.Parse(Console.ReadLine());

                vfinal = preco*(taxa/100);
            Console.Clear();
            Console.WriteLine("Nome do produto: "+nprod);
            Console.WriteLine("Valor do produto: R$"+preco);
            Console.WriteLine("Valor do desconto: R$"+vfinal);
                preco=preco-vfinal;
                    break;
                default:
                Console.WriteLine("Entrada inválida.");
                    break;
                
            }

            Console.WriteLine("Valor final é: R$"+preco);
        }
    }
}
