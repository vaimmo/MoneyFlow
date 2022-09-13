using System;
namespace Money_Flow.Professions
{
    public class Doctor : AbstractCharacter
    {
        public Doctor()
        {
            career = "Doctor";

            professionIncome = 13200;

            Investment = 0;

            PassiveIncome = 0;

            RealEstateBusiness = 0;

            Taxes = 3420;

            RentPayment = 1900;

            StudentLoanPayment = 750;

            CarLoanPayment = 380;

            CreditCardPayment = 270;

            RetailExpenses = 50;

            OtherExpenses = 2880;

            CalculChildExpenses = 640;

            Savings = 400;

            HouseMortgage = 202000;

            StudentLoan = 150000;

            CarLoan = 19000;

            CreditCart = 9000;

            RetailDebt = 1000;
        }
    }
}

