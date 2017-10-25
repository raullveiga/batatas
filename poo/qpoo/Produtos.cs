using System.IO;

namespace qpoo{
    public class Produtos{
        public int id;
        public string nomeProduto, desc;
        double preco;
        
        public string salvar(){
            StreamWriter escr = new StreamWriter("arquivo.csv",true);

            escr.WriteLine(id+";"+nomeProduto+";"+desc+";"+preco);
            escr.Close();
            return "Arquivo salvo";
        }


    }
}