//A bank account has a holder name (first name, middle name and last name), available amount of money 
//(balance), bank name, IBAN, 3 credit card numbers associated with the account. 
//Declare the variables needed to keep the information for a single bank account using the
//appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName;
        string middleName;
        string lastName;
        decimal balance;
        string bankName;
        string IBAN;
        ulong creditCardNumber1;
        ulong creditCardNumber2;
        ulong creditCardNumber3;

        firstName = "Petar";
        middleName = "Iliev";
        lastName = "Atanasov";
        balance = 74531259.35489m;
        bankName = "FiBank";
        IBAN = "BG12055NU332305";
        creditCardNumber1 = 2455236841126555;
        creditCardNumber2 = 1211515151547581;
        creditCardNumber3 = 5454654654654654;
        Console.WriteLine("First Name:{0}\nMiddle Name:{1}\nLast Name:{2}", firstName, middleName, lastName);
        Console.WriteLine("Balans:{0}\nBank Name:{1}\nIBAN:{2}", balance, bankName, IBAN);
        Console.WriteLine("First Credit Card Number:{0}\nSecond Credit Card Number:{1}\nThird Credit Card Number:{2}", creditCardNumber1, creditCardNumber2, creditCardNumber3);



    }
}

