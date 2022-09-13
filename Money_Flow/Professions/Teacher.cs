using System;
namespace Money_Flow.Professions
{
    public class Teacher : AbstractCharacter
    {
        public Teacher()
        {
            career = "Teacher";

            professionIncome = 3300;

            Investment = 0;

            PassiveIncome = 0;

            RealEstateBusiness = 0;

            Taxes = 6300;

            RentPayment = 500;

            StudentLoanPayment = 60;

            CarLoanPayment = 100;

            CreditCardPayment = 90;

            RetailExpenses = 50;

            OtherExpenses = 760;

            CalculChildExpenses = 180;

            Savings = 400;

            HouseMortgage = 50000;

            StudentLoan = 12000;

            CarLoan = 5000;

            CreditCart = 3000;

            RetailDebt = 1000;
        }
    }
}

