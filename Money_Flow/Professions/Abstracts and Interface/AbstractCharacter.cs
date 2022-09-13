using System;
namespace Money_Flow.Professions
{
    public abstract class AbstractCharacter : ICharProfession
    {
        public string Career { get => career; }
        public string career;

        public double ProfessionIncome { get => professionIncome; }
        public double professionIncome;

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
        public double GetChildExpenses { get => CalculChildExpenses; }
        public double CalculChildExpenses { get; set; }

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
            return professionIncome + Investment + Dividends + PassiveIncome + RealEstateBusiness;
        }

        private double OutcomeCalculatuin()
        {
            return Taxes + RentPayment + StudentLoanPayment + CarLoanPayment +
                CreditCardPayment + RetailExpenses + OtherExpenses + CalculChildExpenses;
        }

        //Method to calculate Child Expenses
        public double ChildExpensesCalculation(int ChildCount)
        {
            return CalculChildExpenses = ChildCount * CalculChildExpenses;
        }

        //Money flow calculation
        private double MoneyFlowCalculation()
        {
            return FullIncome - FullExpenses;
        }
    }
}

