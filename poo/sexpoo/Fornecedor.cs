namespace sexpoo{
    public class Fornecedor{
        private int id;
        private string r_social;
        string cnpj;
        string telefone;

        public Fornecedor(){}
        public Fornecedor(int id, string r_social, string cnpj, string telefone){
            this.id = id;
            this.r_social = r_social;
            this.cnpj = cnpj;
            this.telefone = cnpj;
        }

        public int Id {get{return id;} set{id = value;}}
        public string R_social{get{return r_social;} set{r_social = value;}}
        public string Cnpj {get{return cnpj;} set{cnpj = value;}} 
        public string Telefone {get{return telefone;} set{telefone = value;}}
           
        
    }   
}