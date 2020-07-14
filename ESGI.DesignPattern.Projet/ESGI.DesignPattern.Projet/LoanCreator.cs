using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class LoanCreator
    {
        public static Loan NewTermLoan(double commitment, DateTime start, DateTime maturity, int riskRating)
        {
            return new LoanBuilder()
                .WithCommitment(commitment)                
                .WithStartDate(start)
                .WithExpiryDate(null)
                .WithMaturityDate(maturity)
                .WithRiskRating(riskRating)
                .WithStrategy(new CapitalStrategyTermLoan())
                .Build();
        }


        public static Loan NewRevolver(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            return new LoanBuilder()
                .WithCommitment(commitment)
                .WithStartDate(start)
                .WithExpiryDate(expiry)
                .WithMaturityDate(null)
                .WithRiskRating(riskRating)
                .WithStrategy(new CapitalStrategyRevolver())
                .Build();
        }

        public static Loan NewAdvisedLine(double commitment, DateTime start, DateTime expiry, int riskRating)
        {
            if (riskRating > 3) return null;
            return new LoanBuilder()
                .WithCommitment(commitment)
                .WithNotSureWhatThisIs(0)
                .WithStartDate(start)
                .WithExpiryDate(expiry)
                .WithMaturityDate(null)
                .WithRiskRating(riskRating)
                .WithStrategy(new CapitalStrategyAdvisedLine())
                .WithUnusedPercentage(0.1)
                .Build();
        }
    }
}