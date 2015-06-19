namespace BankAccounts
{
    using BankAccounts.AccountInterfaces;
    using System;

    class MortgageAccount : Account, ILoanAccountAndMortgageAccount
    {
        public MortgageAccount(Customers customeR, decimal balancE, double interestRatE)
            : base(customeR, balancE, interestRatE)
        {

        }

        public void DepositMoney(decimal money)
        {
            this.balace += money;
        }

        public override decimal CalculateInterest(int number_of_months)
        {
            if (customer == Customers.company)
            {
                if (number_of_months < 13)
                {
                    this.interestRate /= 2;
                    return (decimal)(number_of_months * this.interestRate);
                }
                else
                {
                    number_of_months -= 12;
                    decimal first12month = (decimal)(12 * this.interestRate) / 2;
                    return (decimal)(number_of_months * this.interestRate) + first12month;
                }

            }
            else
            {
                if (number_of_months <= 6) return 0;
                number_of_months -= 6;
                return (decimal)(number_of_months * this.interestRate);

            }
        }
    }
}
