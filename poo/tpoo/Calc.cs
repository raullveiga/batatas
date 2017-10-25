namespace tpoo{
    /// <summary>
    /// A classe Calc possui 3 métodos sendo eles:
    /// soma *(retorna a soma os valores de um array de doubles)*
    /// média *(retorna a média dos valores de um array de doubles)*
    /// Ex *(retorna o resultado da exponenciação dado a base e expoente dado)*
    /// </summary>
    public class Calc{
        /// <summary>
        /// O método Soma, recebe um array de doubles e soma todos
        /// os valores e retorna o resultado
        /// </summary>
        /// <param name="val">Array de doubles a serem somados</param>
        /// <returns>Retorna a soma em double</returns>
        public double Soma(double[] val){
                double n=0;

                foreach(double i in val)
                    n+=i;
                
                return n;
        }
        /// <summary>
        /// O método Média, recebe um array de doubles e retorna 
        /// a média dos valores recebidos
        /// </summary>
        /// <param name="val">Array de doubles</param>
        /// <returns>Retorna a média em double</returns>
        public double Media(double[] val){
                double n=0;

                n=Soma(val)/val.Length;

                return n;
        }
        /// <summary>
        /// O método Ex, recebe uma base e um expoente inteiros e retorna 
        /// a exponenciação da base pelo expoente
        /// </summary>
        /// <param name="bs">Base do expoente</param>
        /// <param name="exp">Expoente</param>
        /// <returns>Retorna o resultado da exponenciação</returns>
        public double Ex(int bs, int exp){
                int n=1;

                for(int i=0; i<exp;i++){
                n*=bs;
                }

                return n;


        }
    }
}