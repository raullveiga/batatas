using System;

namespace spoo{
    public class cidades{
        /// <summary>
        /// O método Listarcidades, abre um terminal e solicita ao
        /// usuário que digite uma lista de cidades separadas por virgula
        /// - , - e retorna um array de cidades
        /// </summary>
        /// <returns>Retorna um array de strings</returns>
        public string[] ListarCidades(){
            
            Console.WriteLine(@"Digite as cidades separadas por virgula (,)");
            string[] lista = Console.ReadLine().Split(",");
            return lista;
        } 
    }
}