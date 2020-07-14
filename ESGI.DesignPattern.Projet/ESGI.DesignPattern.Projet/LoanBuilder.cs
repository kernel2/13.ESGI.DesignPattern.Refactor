using System;
using System.Collections.Generic;

namespace ESGI.DesignPattern.Projet
{
    public class LoanBuilder
    {
        private double commitment = 1.0;
        private double notSureWhatThisIs = 0;
        private DateTime start = SystemTime.Now;
        private DateTime? expiry;
        private DateTime? maturity;
        private CapitalStrategy capitalStrategy;
        private int riskRating;
        private double unusedPercentage = 1.0;
        private double outstanding = 0;

        public Loan Build()
        {
            return new Loan(
                commitment,
                notSureWhatThisIs,
                start,
                expiry,
                maturity,
                riskRating,
                capitalStrategy,
                unusedPercentage,
                outstanding
            );
        }

        public LoanBuilder WithCommitment(double commitment)
        {
            this.commitment = commitment;
            return this;
        }

        public LoanBuilder WithNotSureWhatThisIs(double notSureWhatThisIs)
        {
            this.notSureWhatThisIs = notSureWhatThisIs;
            return this;
        }

        public LoanBuilder WithUnusedPercentage(double unusedPercentage)
        {
            this.unusedPercentage = unusedPercentage;
            return this;
        }

        public LoanBuilder WithStartDate(DateTime start)
        {
            this.start = start;
            return this;
        }

        public LoanBuilder WithExpiryDate(DateTime? expiry)
        {
            this.expiry = expiry;
            return this;
        }

        public LoanBuilder WithMaturityDate(DateTime? maturity)
        {
            this.maturity = maturity;
            return this;
        }

        public LoanBuilder WithRiskRating(int riskRating)
        {
            this.riskRating = riskRating;
            return this;
        }

        public LoanBuilder WithStrategy(CapitalStrategy capitalStrategy)
        {
            this.capitalStrategy = capitalStrategy;
            return this;
        }

    }
}