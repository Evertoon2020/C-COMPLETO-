using System.Globalization;


namespace Atividade4_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioB;
        public double Irpf;

        public double SalarioL()
        {
            return SalarioB - Irpf;
        }
        public void Aumento(double porcentagem)
        {
            SalarioB += (SalarioB * porcentagem / 100);
        }
        public override string ToString()
        {
            return Nome
                +", R$"
                + SalarioL().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
