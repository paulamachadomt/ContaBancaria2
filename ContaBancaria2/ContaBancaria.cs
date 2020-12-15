using System;
using System.Globalization;

namespace ContaBancaria2
{
    class ContaBancaria
    {
        public string NumeroConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public double LimiteDeSaque { get; set; }

        public ContaBancaria(string numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Saldo = saldo;            

            ImprimeDadosBancarios(this);
        }

        public static ContaBancaria AberturaContaBancaria()
        {
            Console.Write("Digite o número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Digite o nome do titular: ");
            string nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/N)? ");
            string escolhaDepositoInicial = Console.ReadLine();


            double deposito = 0.0;

            if (escolhaDepositoInicial.ToLower() == "s")
            {
                Console.Write("Digite o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria contaBancaria = new ContaBancaria(numeroConta, nomeTitular, deposito);
            return contaBancaria;
        }



        public void Deposito(ContaBancaria contaBancaria)
        {
            Console.Write("Entre um valor para o depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Saldo += valor;
            ImprimeDadosBancarios(contaBancaria);
        }



        public void Saque(ContaBancaria contaBancaria)
        {
            LimiteDeSaque = 500;
            Console.Write("Entre um valor para saque:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > LimiteDeSaque)
            {
                Console.Write("Valor superior ao seu limite de saque!");                
            }
            else
            {
                Saldo -= valor + 5;
                ImprimeDadosBancarios(contaBancaria);
            }
        }


        public void ImprimeDadosBancarios(ContaBancaria contaBancaria)
        {
            Console.WriteLine();
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaBancaria.ToString());
            Console.WriteLine();
        }


        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + NomeTitular + ", Saldo: $ " + Saldo.ToString("F2");
        }


    }
}
