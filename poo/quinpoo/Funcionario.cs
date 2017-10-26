using System;
using System.IO;

namespace quinpoo{
    /// <summary>
    /// A classe funcionario recebe os dados 
    /// solicidados de um funcionario e os escreve 
    /// em um arquivo de csv.
    /// </summary>
    public class Funcionario{
        private int id;
        private string nome, cargo, depart;
        /// <summary>
        /// O método construtor Funcionario, pede os dados
        /// necessários para gravar os dados do funcionario
        /// no arquivo csv.
        /// </summary>
        /// <param name="id">Passe o id como int</param>
        /// <param name="nome">Passe o nome como string</param>
        /// <param name="cargo">Passe o cargo como string</param>
        /// <param name="depart">Passe o depart como string</param>
        public Funcionario(int id, string nome, string cargo, string depart){

            this.id = id;
            this.nome = nome;
            this.cargo = cargo;
            this.depart = depart;
        }
        public Funcionario(){

        }
        /// <summary>
        /// O método salvar, grava os dados 
        /// em um arquivo csv.
        /// </summary>
        /// <returns></returns>
        public string Salvar(){
            string msg = "";

            StreamWriter escrever = null;
            try{
                escrever = new StreamWriter("funcionario.csv",true);
                escrever.WriteLine(id+";"+nome+";"+cargo+";"+depart);

                msg = "Arquivo salvo com sucesso!";
            }
            catch(Exception jorge){
                msg = "Erro ao tentar manipular o arquivo."+jorge.Message;
            }
            finally{
                escrever.Close();
            }

            return msg;

        }

        public int Id{
            get{return id;}
            set{id=value;}
        }
        public string Nome{
            get{return nome;}
            set{nome = value;}
        }
        public string Cargo{
            get{return cargo;}
            set{cargo = value;}
        }
        public string Depart{
            get{return depart;}
            set{depart = value;}
        }


    }
}