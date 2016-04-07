using System;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Today;

            string birthday = Console.ReadLine();
            int inputYear = int.Parse(birthday.Substring(6, 4));
            int inputMonth = int.Parse(birthday.Substring(0, 2));
            int age = date.Year - inputYear;
            if (inputMonth > date.Month)
            {
                age--;
            }

            int ageAfterTenYears = age + 10;

            Console.WriteLine(age);
            Console.WriteLine(ageAfterTenYears);
        }
    }
}
