//A bank account has a holder name (first name, middle name and last name),
//available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single 
//bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Deiv";
        string middleName = "Mustain";
        string lastName = "Toncho";
        double accountMoneyBalance = 65566.2226;
        string bankName = "Mortal Kombat !";
        string IBAN = "BG424001943";
        long firstCreditCard = 8724324235;
        long secontCreditCard = 4324235340;
        long thirdCreditCard = 6324235325;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}", firstName, middleName, lastName, accountMoneyBalance, bankName, IBAN, firstCreditCard, secontCreditCard, thirdCreditCard);
    }
}