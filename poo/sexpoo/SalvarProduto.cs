using System;
using System.IO;

namespace sexpoo
{
    public class SalvarProduto
    {
        public string Salvar(Produto produto)
        {
            string msg = "";
            StreamWriter arquivo = null;
            try
            {
                arquivo = new StreamWriter("produtos.csv", true);
                arquivo.WriteLine(produto.Id);
                arquivo.WriteLine(produto.Nome);
                arquivo.WriteLine(produto.Preco);
                arquivo.WriteLine(produto.fornecedores.R_social);

                msg = "Arquivo salvo com sucesso!";
            }
            catch (Exception e)
            {
                msg = "Erro ao gravar" + e.Message;
            }
            finally
            {
                arquivo.Close();
            }

            return msg;
        }


    }
}