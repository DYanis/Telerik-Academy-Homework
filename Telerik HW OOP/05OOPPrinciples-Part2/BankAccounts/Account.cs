namespace BankAccounts
{
    using System;

    public abstract class Account
    {
        protected Customers customer;

        protected decimal balace;

        protected double interestRate;

        public decimal Balance { get { return this.balace; } }

        public Account(Customers customeR, decimal balancE, double interestRatE)
        {
            this.customer = customeR;
            this.balace = balancE;
            this.interestRate = interestRatE;
        }

        public abstract decimal CalculateInterest(int number_of_months);  
    }
}
