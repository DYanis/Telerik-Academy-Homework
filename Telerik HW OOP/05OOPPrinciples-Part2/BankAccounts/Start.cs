namespace BankAccounts
{
    using System;

    class Start
    {
        static void Main()
        {
            var depositAcount = new DepositAccount(Customers.individual, 11500, 3);
            Console.WriteLine(depositAcount.Balance);

            depositAcount.DepositMoney(6000);
            Console.WriteLine(depositAcount.Balance);
            depositAcount.WithdrawMoney(4000);
            Console.WriteLine(depositAcount.Balance);
        }
    }
}
