using System;

namespace sexpoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor fr = new Fornecedor();
                fr.Id = 24;
                fr.R_social = "unidsa";
                fr.Telefone = "21353";
                fr.Cnpj = "6465465";

            Produto pr = new Produto();
                pr.Id = 213;
                pr.Nome = "Extrado de batata";
                pr.Preco = 5.5;
                pr.fornecedores = fr;

            SalvarProduto sp = new SalvarProduto();

            Console.WriteLine(sp.Salvar(pr));
        }
    }
}
