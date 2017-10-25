using System;

namespace ppoo
{
    class Program
    {
        static void Main(string[] args)
        {
            cCliente cliente = new cCliente();
            cliente.nome    = "Raul";
            cliente.email   = "batata@hotmail.com";
            cliente.telefone= "894378943789";

            cliente.gravar();
            
        }
    }
}
