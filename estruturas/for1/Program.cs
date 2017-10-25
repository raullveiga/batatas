using System;

namespace for1
{
    class Program
    {
        static void Main(string[] args)
        {
            

             for(int i=0;i<=50;i+=2){
                Console.WriteLine(i);
            }
 
            
            for(int i=0;i<=50;i++){
                if(i%2==0)
                    Console.WriteLine(i);
            }
 



            /* string nome ="Batata";

            for(int i=nome.Length-1; i >= 0 ;i--){
                Console.WriteLine(nome[i]);
            } */
        }
    }
}
