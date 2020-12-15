using System;

namespace ContaBancaria2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aciona o método estático de abertura da conta e imprime os dados da conta 
            ContaBancaria contaBancaria = ContaBancaria.AberturaContaBancaria();

            //Depósito 
            contaBancaria.Deposito(contaBancaria);


            //Saque
            contaBancaria.Saque(contaBancaria);


            //Fim
            Console.ReadLine();
        }
    }
}
