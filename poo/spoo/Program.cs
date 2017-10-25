using System;

namespace spoo
{
    class Program
    {
        static void Main(string[] args)
        {
            cidades ci = new cidades();
            
            foreach(string i in ci.ListarCidades())
                Console.WriteLine(i);
            


            

            

        }
    }
}
