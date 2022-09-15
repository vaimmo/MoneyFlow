using System;
namespace Money_Flow
{
    public interface ICharProfession
    {
        public string Career { get; }

        public double ProfessionIncome { get; }

        //Income
        public double Investment { get; set; }
        public double Dividends { get; set; }
        public double PassiveIncome { get; set; }
        public double RealEstateBusiness { get; set; }

        //Outcome
        public double Taxes { get; set; }
        public double RentPayment { get; set; }
        public double StudentLoanPayment { get; set; }
        public double CarLoanPayment { get; set; }
        public double CreditCardPayment { get; set; }
        public double RetailExpenses { get; set; }
        public double OtherExpenses { get; set; }
        public double GetChildExpenses { get;}

        public double Savings { get; set; }

        //Liabilities
        public double HouseMortgage { get; set; }

        public double StudentLoan { get; set; }

        public double CarLoan { get; set; }

        public double CreditCart { get; set; }

        public double RetailDebt { get; set; }
    }
}

