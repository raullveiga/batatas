using System;

namespace desvio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração da variável notaAluno

            double notaAluno;
            

            
            /*
             Vamos requisitar a nota ao usuário e guardar na variável
             notaAluno
             */

            Console.Write("Digite a nota do aluno: ");
            notaAluno = Convert.ToDouble(Console.ReadLine());

            /*  Se o aluno ntiver uma nota maior ou igual a 7, etnão ele estará aprovado;
                Caso contrario, estará reprovado. */
            /*
            if(notaAluno >= 7){
                Console.Write("Aprovado");
                    if(notaAluno==10)
                        Console.WriteLine(" Perfeito");}
            else   
                Console.WriteLine("Reprovado");
            */
            
            /*  Se o aluno tiver uma nota maior ou igual a 7,
                então ele estará aprovado;
                Caso o aluno tenha uma nota menor ou igual a 4,
                então ele estará reprovado;
                Caso contrário, ele estará em recuperação.*/

            if(notaAluno>=7)
                Console.WriteLine("Aprovado!");
            else if(notaAluno<=4)
                Console.WriteLine("Reprovado.");
            else
                Console.WriteLine("Recuperação.");

            






        }
    }
}
