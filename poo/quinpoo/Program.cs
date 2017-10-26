using System;

namespace quinpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            f.Id = 423;
            f.Nome = "batatata";
            f.Cargo = "!fsad";
            f.Depart = "fsf";
            Console.WriteLine(f.Salvar());
            
        }
    }
}
