namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return (loan._outstanding * Duration(loan) * RiskFactorFor())
                        + (loan.UnusedRiskAmount() * Duration(loan) * UnusedRiskFactorFor());
        }

    }
}