using System;
namespace Money_Flow.Professions
{
    public class Doorman : AbstractCharacter
    {
        public Doorman()
        {
            career = "Doorman";

            professionIncome = 1600;

            Investment = 0;

            PassiveIncome = 0;

            RealEstateBusiness = 0;

            Taxes = 280;

            RentPayment = 200;

            StudentLoanPayment = 0;

            CarLoanPayment = 60;

            CreditCardPayment = 60;

            RetailExpenses = 50;

            OtherExpenses = 300;

            CalculChildExpenses = 70;

            Savings = 400;

            HouseMortgage = 25000;

            StudentLoan = 0;

            CarLoan = 10000;

            CreditCart = 2000;

            RetailDebt = 1000;
        }
    }
}

