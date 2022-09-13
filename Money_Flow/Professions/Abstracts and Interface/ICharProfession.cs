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

        public double FullIncome { get => IncomeCalucaliton(); }

        //Outcome
        public double Taxes { get; set; }
        public double RentPayment { get; set; }
        public double StudentLoanPayment { get; set; }
        public double CarLoanPayment { get; set; }
        public double CreditCardPayment { get; set; }
        public double RetailExpenses { get; set; }
        public double OtherExpenses { get; set; }
        public double GetChildExpenses { get;}


        public double FullExpenses { get => OutcomeCalculatuin(); }

        public double MoneyFlow { get => MoneyFlowCalculation(); }

        public double Savings { get; set; }

        //Liabilities
        public double HouseMortgage { get; set; }

        public double StudentLoan { get; set; }

        public double CarLoan { get; set; }

        public double CreditCart { get; set; }

        public double RetailDebt { get; set; }

        private double IncomeCalucaliton()
        {
            return Investment + Dividends + PassiveIncome + RealEstateBusiness;
        }

        private double OutcomeCalculatuin()
        {
            return Taxes + RentPayment + StudentLoanPayment + CarLoanPayment +
                CreditCardPayment + RetailExpenses + OtherExpenses + GetChildExpenses;
        }

        //Method to calculate Child Expenses
        public double ChildExpensesCalculation(int ChildCount)
        {
            return 100;
        }

        //Money flow calculation
        private double MoneyFlowCalculation()
        {
            return FullIncome - FullExpenses;
        }
    }
}

