using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0204
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            op = "0";
            Console.WriteLine("/---MENU---/\n\n Escolha a opção:\n\n 1 - opção 1\n 2 - Opção 2\n Q - Sair!");
            while ((op.ToUpper() != "Q"))
            {
                Console.WriteLine("deseja continuar");
                op = Console.ReadLine();
                if (op.Length < 2)
                {
                    switch (op)
                    {
                        case "1":
                            Console.WriteLine("Você escolheu a opção 1 ");
                            break;
                        case "2":
                            Console.WriteLine("Você escolheu a opção 2 ");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Você digitou uma opção invalida");
                    op = "i";
                }
            }

        }
    }
}
