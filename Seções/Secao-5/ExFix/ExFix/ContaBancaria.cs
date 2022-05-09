using System.Globalization;

namespace ExFix
{
    class ContaBancaria
    {
        private string Nome { get; set; } // Pode ser alterado
        public int Conta { get; private set; } //Não poderá ser alterado
        public double Saldo { get; private set; } //Não poderá ser alterado

        public ContaBancaria(string nome, int conta) //Primeiro construtor
        {
            Nome = nome;
            Conta = conta;
        }
        public ContaBancaria(string nome, int conta, double depositoInicial) : this(nome, conta) //Sobrecarga
        {
            Deposito (depositoInicial);
        }

        public void Deposito(double saldo) //Metodo
        {
            Saldo += saldo;
        }

        public void Saque(double saldo) //Metodo
        {
            Saldo = (Saldo - saldo) - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
            + Conta
            + ", Titular: "
            + Nome
            + ", Saldo: R$"
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
