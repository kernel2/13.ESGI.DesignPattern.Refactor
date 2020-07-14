using System;
namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyTermLoan : CapitalStrategy
    {
        private readonly double EPSILON = 0.001;

        public override double Capital(Loan loan)
        {
            return loan._commitment * Duration(loan) * RiskFactorFor(loan);
        }

        public override double Duration(Loan loan)
        {
            return WeightedAverageDuration(loan);
        }

        private double WeightedAverageDuration(Loan loan)
        {
            double duration = 0.0;
            double weightedAverage = 0.0;
            double sumOfPayments = 0.0;

            foreach (var payment in loan._payments)
            {
                sumOfPayments += payment.Amount;
                weightedAverage += YearsTo(payment.Date, loan) * payment.Amount;
            }

            if (Math.Abs(loan._commitment) > EPSILON)
            {
                duration = weightedAverage / sumOfPayments;
            }

            return duration;
        }
    }
}