using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo11._1
{
    class Program
    {
        String nome;
        float saldo;
        static void Main()
        {
 
        }
        void Cadastrar( String nome, float saldo)
        {
            Console.WriteLine(" Insira seu nome!");
            nome = Console.ReadLine();
            Console.WriteLine(" Informe o saldo em conta!");
            saldo = float.Parse(Console.ReadLine());
        }
        float Consultar(float saldo)
        {
            Console.WriteLine(" Insira seu nome!");
            Console.WriteLine(" Informe o saldo em conta!");
            return saldo;
        }
        void Depositar(float saldo)
        {
            Console.WriteLine(" Qual o valor a ser depositado?");
            saldo = float.Parse(Console.ReadLine());

        }
        void Sacar(float saque, float saldo)
        {
            Console.WriteLine(" Qual o valor do saque?");
            saque = float.Parse(Console.ReadLine());
            if (saque <= saldo) 
            {
                saldo = saldo - saque;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
            Console.ReadKey();
        }
    }

}
