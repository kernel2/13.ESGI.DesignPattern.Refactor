namespace ESGI.DesignPattern.Projet
{
    public class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan._commitment * loan._unusedPercentage * Duration(loan) * RiskFactorFor(loan);
        }
    }
}