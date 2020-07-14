using System;
namespace ESGI.DesignPattern.Projet
{
    public abstract class CapitalStrategy
    {

        private const long MILLIS_PER_DAY = 86400000;
        private const long DAYS_PER_YEAR = 365;

        public abstract double Capital(Loan loan);

        protected double RiskFactorFor()
        {
            return RiskFactor.riskRating;
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