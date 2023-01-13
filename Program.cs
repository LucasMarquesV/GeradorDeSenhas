using System;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Bem vindo ao gerador de senhas!");
                Console.WriteLine("Qual a quantidade de caracteres para a necessário para a senha?");
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine();

                    int qnt = int.Parse(Console.ReadLine());
                
                
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------");

                string caracteresPossiveis = "ABCDEFGHIJKLMNOPQRSTUVWXYZ" + "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower() + "0123456789" + "?!@#%";

                Random random = new Random();
                int numeroSorteado = 0;

                StringBuilder password = new StringBuilder();


                for (int t = 0; t < qnt; t++)
                {
                    numeroSorteado = random.Next(0, caracteresPossiveis.Length - 1);
                    password.Append(caracteresPossiveis[numeroSorteado]);

                }
                Console.WriteLine();
                Console.WriteLine("A sua senha com " + qnt+" caracteres é: " + password);
                Console.WriteLine();
                Console.WriteLine("-----------------------------------------------------------------------------");
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Deseja utilizar o aplicativo novamente? Digite 'SIM' para utilizar novamente");
                Console.WriteLine();
            } while (Console.ReadLine().ToUpper() == "SIM");

            Console.WriteLine("OBRIGADO! ATÉ A PROXIMA!");
            Console.ReadKey();
        }
    }
}

