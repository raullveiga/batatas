using System;
using System.IO;
namespace cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração das variavéis base
            string nome, email, end, idade, rg, cpf, eCivil, filhos = "0", dp, cargo, salario, hEntrada, hSaida;
            string mod;

            Console.Clear();


            Console.Write("Nome completo: ");                                               //Verica se o arquivo já existe, com base no
            nome = Console.ReadLine();                                                      //nome do cadastro.
            FileInfo arq = new FileInfo(nome + ".txt");
            if (arq.Exists)
            {
                Console.WriteLine("O nome de cadastro já existe. Deseja sobrescrever? ");
                if (Console.ReadLine().ToUpper() == "SIM")
                {
                    StreamWriter cf = new StreamWriter(nome + ".txt");
                    mod = Convert.ToString(arq.LastWriteTime);

                    Console.Clear();
                    Console.Write("E-mail: ");
                    email = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Endereço: ");
                    end = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Idade: ");
                    idade = Console.ReadLine();
                    Console.Clear();
                    Console.Write("RG: ");
                    rg = Console.ReadLine();
                    Console.Clear();
                    Console.Write("CPF: ");
                    cpf = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Estado Civil: ");
                    eCivil = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Tem Filhos: ");
                    if (Console.ReadLine().ToUpper() == "SIM")
                    {
                        Console.Clear();
                        Console.Write("Quantos? ");
                        filhos = Console.ReadLine();
                    }
                    Console.Clear();
                    Console.Write("Departamento:");
                    dp = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Cargo: ");
                    cargo = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Salário: ");
                    salario = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Horário de Entrada:");
                    hEntrada = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Horário de Saída: ");
                    hSaida = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("Nome: " + nome);
                    Console.WriteLine("E-mail: " + email);
                    Console.WriteLine("Endereço: " + end);
                    Console.WriteLine("Idade: " + idade);
                    Console.WriteLine("RG: " + rg);
                    Console.WriteLine("CPF: " + cpf);
                    Console.WriteLine("Estado Civil: " + eCivil);
                    Console.WriteLine("Nº de Filhos: " + filhos);
                    Console.WriteLine("Departamento: " + dp);
                    Console.WriteLine("Cargo: " + cargo);
                    Console.WriteLine("Salario: " + salario);
                    Console.WriteLine("Horario de entrada: " + hEntrada);
                    Console.WriteLine("Horario de saída: " + hSaida);
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Confirma os dados do cadastro? ");
                    if (Console.ReadLine().ToUpper() == "SIM")
                    {
                        cf.WriteLine(nome);
                        cf.WriteLine(email);
                        cf.WriteLine(end);
                        cf.WriteLine(idade);
                        cf.WriteLine(rg);
                        cf.WriteLine(cpf);
                        cf.WriteLine(eCivil);
                        cf.WriteLine(filhos);
                        cf.WriteLine(dp);
                        cf.WriteLine(cargo);
                        cf.WriteLine(salario);
                        cf.WriteLine(hEntrada);
                        cf.WriteLine(hSaida);

                        cf.Close();

                        FileInfo arq2 = new FileInfo(nome + ".txt");

                        if (mod != Convert.ToString(arq2.LastWriteTime))
                        {
                            Console.WriteLine("Cadastro realizado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Falha na criação do arquivo");
                        }
                    }
                    else
                    {
                        Console.WriteLine("O cadastro não foi criado.");
                    }
                }
            }
            else{
                StreamWriter cf = new StreamWriter(nome + ".txt");
                mod = Convert.ToString(arq.LastWriteTime);

                Console.Clear();
                Console.Write("E-mail: ");
                email = Console.ReadLine();
                Console.Clear();
                Console.Write("Endereço: ");
                end = Console.ReadLine();
                Console.Clear();
                Console.Write("Idade: ");
                idade = Console.ReadLine();
                Console.Clear();
                Console.Write("RG: ");
                rg = Console.ReadLine();
                Console.Clear();
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Clear();
                Console.Write("Estado Civil: ");
                eCivil = Console.ReadLine();
                Console.Clear();
                Console.Write("Tem Filhos: ");
                if (Console.ReadLine().ToUpper() == "SIM")
                {
                    Console.Clear();
                    Console.Write("Quantos? ");
                    filhos = Console.ReadLine();
                }
                Console.Clear();
                Console.Write("Departamento:");
                dp = Console.ReadLine();
                Console.Clear();
                Console.Write("Cargo: ");
                cargo = Console.ReadLine();
                Console.Clear();
                Console.Write("Salário: ");
                salario = Console.ReadLine();
                Console.Clear();
                Console.Write("Horário de Entrada:");
                hEntrada = Console.ReadLine();
                Console.Clear();
                Console.Write("Horário de Saída: ");
                hSaida = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("E-mail: " + email);
                Console.WriteLine("Endereço: " + end);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("RG: " + rg);
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("Estado Civil: " + eCivil);
                Console.WriteLine("Nº de Filhos: " + filhos);
                Console.WriteLine("Departamento: " + dp);
                Console.WriteLine("Cargo: " + cargo);
                Console.WriteLine("Salario: " + salario);
                Console.WriteLine("Horario de entrada: " + hEntrada);
                Console.WriteLine("Horario de saída: " + hSaida);
                Console.WriteLine("------------------------");
                Console.WriteLine("Confirma os dados do cadastro? ");
                if (Console.ReadLine().ToUpper() == "SIM")
                {
                    cf.WriteLine(nome);
                    cf.WriteLine(email);
                    cf.WriteLine(end);
                    cf.WriteLine(idade);
                    cf.WriteLine(rg);
                    cf.WriteLine(cpf);
                    cf.WriteLine(eCivil);
                    cf.WriteLine(filhos);
                    cf.WriteLine(dp);
                    cf.WriteLine(cargo);
                    cf.WriteLine(salario);
                    cf.WriteLine(hEntrada);
                    cf.WriteLine(hSaida);

                    cf.Close();

                    FileInfo arq2 = new FileInfo(nome + ".txt");

                    if (mod != Convert.ToString(arq2.LastWriteTime))
                    {
                        Console.WriteLine("Cadastro realizado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Falha na criação do arquivo");
                    }
                }
                else
                {
                    Console.WriteLine("O cadastro não foi criado.");
                }
            }

        }
    }
}
