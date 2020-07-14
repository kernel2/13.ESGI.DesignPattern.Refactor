using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {

        private long MILLIS_PER_DAY = 86400000;
        private long DAYS_PER_YEAR = 365;

        public abstract double Capital(Loan loan);

        protected double RiskFactorFor(Loan loan)
        {
            return RiskFactor.GetFactors().ForRating(loan._riskRating);
        }

        private double UnusedRiskFactorFor(Loan loan)
        {
            return UnusedRiskFactors.GetFactors().ForRating(loan._riskRating);
        }

        public virtual double Duration(Loan loan)
        {
            return YearsTo(loan._expiry, loan);
        }

        protected double YearsTo(DateTime? endDate, Loan loan)
        {
            DateTime? beginDate = (loan._today.HasValue? loan._today : loan._start);
            return (double)((endDate?.Ticks - beginDate?.Ticks) / MILLIS_PER_DAY / DAYS_PER_YEAR);
        }
    }
}