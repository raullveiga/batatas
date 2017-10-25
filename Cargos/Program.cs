using System;

namespace Cargos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis base
            string cargos;
            double s;

            Console.Write("Digite o nome do cargo a ser consultado: ");
            cargos = Console.ReadLine().ToUpper();

            switch(cargos)
            {
                case "DIRETOR":
                    s = 15.000D;
                    break;

                case "GERENTE":
                    s = 12.000D;
                    break;

                case "ANALISTA":
                    s = 8.000D;
                    break;

                case "ASSISTENTE":
                    s = 4.000D;
                    break;

                case "AUXILIAR":
                    s = 2.000D;
                    break;

                default:
                    Console.WriteLine("Não há salario.");
                    break;
            }
        Console.WriteLine("R${0}",s);
        }
    }
}
