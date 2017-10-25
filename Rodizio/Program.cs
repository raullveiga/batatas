using System;

namespace rodizio
{
    class Program
    {
        static void Main(string[] args)
        {
        string nPlaca;
        int nTam;
        int nPlac;
        Console.Clear();
        //solicita ao usuário que dígite a placa do veículo
        Console.Write("Digite a placa do veículo: ");
        nPlaca = Console.ReadLine();
        nTam = nPlaca.Length;
        nPlaca = nPlaca.Substring(nTam-1);
        
        if(nPlaca == "1" ^ nPlaca == "2" )
            Console.WriteLine("Seg");
            else if(nPlaca == "3" ^ nPlaca == "4" )
                Console.WriteLine("ter");
            else if(nPlaca == "5" ^ nPlaca == "6" )
                Console.WriteLine("quar");
            else if(nPlaca == "7" ^ nPlaca == "8" )
                Console.WriteLine("quin");
            else if(nPlaca == "9" ^ nPlaca == "0")
                Console.WriteLine("sex");
           

        /* nPlac = Convert.ToInt32(nPlaca);

        switch(nPlac)
        {
            case 1 ^ 2:
                 Console.WriteLine("Seg");
                 break;
            case 3 ^ 4:
                 Console.WriteLine("Ter");
                 break;
             case 5 ^ 6:
                 Console.WriteLine("Ter");
                 break;
            case 7 ^ 8:
                 Console.WriteLine("Quin");
                 break;
            case 9 ^ 0:
                Console.WriteLine("Sex");
                break;
            default:
                Console.WriteLine("Entrada inválida");
                break;
        } */
        }
    }
}
