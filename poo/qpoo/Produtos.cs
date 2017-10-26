using System.IO;

namespace qpoo
{
    public class Produtos
    {
        public Produtos(int id, string nomeProduto, string desc, double preco){
            this.id = id;
            this.nomeProduto = nomeProduto;
            this.desc = desc;
            this.preco = preco;
        }
        public int id;
        public string nomeProduto, desc;
        double preco;

        public string salvar()
        {
            StreamWriter escr = new StreamWriter("arquivo.csv", true);

            escr.WriteLine(id + ";" + nomeProduto + ";" + desc + ";" + preco);
            escr.Close();
            return "Arquivo salvo";
        }

    
    }
}
