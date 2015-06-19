namespace BankAccounts
{
    using BankAccounts.AccountInterfaces;
    using System;

    class LoanAccount : Account, ILoanAccountAndMortgageAccount
    {
        public LoanAccount(Customers customeR, decimal balancE, double interestRatE)
            : base(customeR, balancE, interestRatE)
        {

        }

        public void DepositMoney(decimal money)
        {
            this.balace += money;
        }

        public override decimal CalculateInterest(int number_of_months)
        {
            if (this.customer == Customers.individual)
            {
                number_of_months -= 3;
                return (decimal)(number_of_months * this.interestRate);
            }

            if (this.customer == Customers.company)
            {
                number_of_months -= 2;
                return (decimal)(number_of_months * this.interestRate);
            }

            return 0;
        }
    }
}
