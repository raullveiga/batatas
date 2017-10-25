using System;
using System.IO;

namespace ppoo{
    public class cCliente{
        public  string nome;
        public  string email;
        public  string telefone;

        /// <summary>
        /// O método Gravar, salva os dados em um arquivo de texto
        /// localizado na pasta raiz do projeto
        /// </summary>
        public  void gravar(){
            //Gravar em um arquivo de texto

            StreamWriter st = new StreamWriter("arquivo.rtf",true);

            st.WriteLine("Nome: {0}\tE-mail: {1}\tTelefone; {2}\n",nome,email,telefone);
            /* st.Write("Nome:\t"+nome);
            st.Write("E-mail:\t"+email);
            st.Write("Telefone:\t"+telefone);
            st.WriteLine(""); */

            st.Close();

            Console.WriteLine("Salvo com sucesso!");

        }
    }


}