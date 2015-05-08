using BankAccounts.AccountInterfaces;
namespace BankAccounts
{
    using System;

    class DepositAccount : Account ,IDepositAcc
    {
        public DepositAccount(Customers customeR, decimal balancE, double interestRatE):base(customeR,balancE,interestRatE)
        {

        }

        public void DepositMoney(decimal money)
        {
            this.balace += money;
        }

        public void WithdrawMoney(decimal money)
        {
            this.balace -= money;
        }

        public override decimal CalculateInterest(int number_of_months)
        {
            if (this.balace < 1001 && this.balace > 0)
            {
                return 0;
            }
            else
                return (decimal)(number_of_months * this.interestRate);
        }
    }
}
