

using System.Globalization;

namespace polimorph.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditure {get; set;}

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditure) : base(name, anualIncome)
        {
            HealthExpenditure = healthExpenditure;
        }

        public override double Tax() {
            if(AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HealthExpenditure * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditure * 0.5;
            }
        }

    }
}
