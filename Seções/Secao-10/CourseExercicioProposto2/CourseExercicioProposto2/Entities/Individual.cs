namespace CourseExercicioProposto2.Entities
{
    class Individual : TaxPayer 
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome,double healthExpenditures) : base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (Anuallncome < 20000.00 )
            {
                return (Anuallncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else
            {
                return (Anuallncome * 0.25) - (HealthExpenditures * 0.50);
            }
        }
    }
}
