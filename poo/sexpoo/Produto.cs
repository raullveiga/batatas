namespace sexpoo{
    public class Produto{
        private int id;
        private string nome;
        private double preco;
        private Fornecedor fornecedor;

        public Produto(){}
        public Produto(int id, string nome, double preco, Fornecedor fornecedores)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.fornecedor = fornecedores;
        }

        public int Id
        {
            get { return id;}
            set { id = value;}
        }
        public string Nome
        {
            get { return nome;}
            set { nome = value;}
        }
        public double Preco
        {   
            get { return preco;}
            set { preco = value;}
        }
        
        public Fornecedor fornecedores
        {
            get { return fornecedor;}
            set { fornecedor = value;}
        }
        
        
    }
}