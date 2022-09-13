using System;
namespace Money_Flow.Professions
{
    public class PoliceOfficer : AbstractCharacter
    {
        public PoliceOfficer()
        {
            career = "Police Officer";

            professionIncome = 3000;

            Investment = 0;

            PassiveIncome = 0;

            RealEstateBusiness = 0;

            Taxes = 580;

            RentPayment = 400;

            StudentLoanPayment = 0;

            CarLoanPayment = 100;

            CreditCardPayment = 60;

            RetailExpenses = 50;

            OtherExpenses = 690;

            CalculChildExpenses = 160;

            Savings = 400;

            HouseMortgage = 46000;

            StudentLoan = 0;

            CarLoan = 5000;

            CreditCart = 2000;

            RetailDebt = 1000;
        }
    }
}

