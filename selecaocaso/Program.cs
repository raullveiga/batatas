using System;

namespace selecaocaso
{
    class Program
    {
        static void Main(string[] args)
        {
           string nome = "frederico";
            Console.Clear();
            nome = Console.ReadLine();
            Console.WriteLine(nome.Substring(0,1).ToLower()+nome.Substring(1).ToUpper());
            




        }
    }
}
