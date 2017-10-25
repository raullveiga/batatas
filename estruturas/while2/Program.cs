using System;
using System.IO;
using System.Text;

namespace while2
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader ler = new StreamReader("text.txt", Encoding.Default);

            //Console.WriteLine(ler.ReadToEnd()+"\n ------------------------------------------------------------------");
            string texto ="";
            while( (texto=ler.ReadLine()) != null) {
                Console.WriteLine(texto);
            }
            
            ler.Close();



           /*  string ope= "batata";
            int i=1, n;     
            
            while(ope != "SAIR"){
            Console.WriteLine("Digite a operação desejada entre: \n adição \n subtração \n divisão \n multiplicação");
            ope = Console.ReadLine().ToUpper();

            
            switch(ope){
                case "MULTIPLICAÇÂO":
                    Console.WriteLine("Digite o valor a ser multiplicado");
                    
                break;

                case "ADIÇÂO":
                    Console.WriteLine("");
                    
                break;
                
                case "SUBTRAÇÂO":
                    Console.WriteLine("");
                    
                break;

                case "DIVISÂO":
                    Console.WriteLine("");
                    
                break;

                default: 
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
            } */
        }
    }
}
