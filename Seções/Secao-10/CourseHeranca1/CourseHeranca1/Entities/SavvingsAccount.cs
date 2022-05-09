namespace CourseHeranca1.Entities
{
     class SavvingsAccount : Account   // sealed para selar e evitar a herança
    {
        public double InterestRate { get; set; }

        public SavvingsAccount()
        {

        }

        public SavvingsAccount(int number, string holder, double balance,double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //sealed para não sobrepor esse metodo em outra classe
        {
            //Balance -= amount;
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
