//A marketing company wants to keep record of its employees.
//Each record would have the following characteristics:
//First name
//Last name
//Age(0...100)
//Gender(m or f)
//Personal ID number(e.g. 8306112507)
//Unique employee number(27560000…27569999)
//Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
//Use descriptive names.Print the data at the console.

using System;

    class EmployeeData
    {
        static void Main()
        {
        string firstName = "Daniela";
        string lastName = "Ivanova";
        byte age = 31;
        char gender='f';
        long personalIdNumber = 8306112507;
        int uniqueEmployeeNumber = 27569999;
        Console.WriteLine("First Name is:{0}\nLast Name is:{1}\nAge:{2}\nYour gender is:{3}\nPersonal ID:{4}\nUnique ENumber:{5}",firstName,lastName,age,gender,personalIdNumber,uniqueEmployeeNumber);

        }
    }

