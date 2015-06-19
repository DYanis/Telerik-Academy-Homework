namespace BankAccounts.AccountInterfaces
{
    using System;

    public interface IDepositAcc
    {
        void DepositMoney(decimal money);

        void WithdrawMoney(decimal money);
    }
}