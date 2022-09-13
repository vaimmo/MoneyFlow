using System;
using System.Collections.Generic;
namespace Money_Flow.GameMechanics
{
    public class Payout
    {

        //private List<int> payoutField = new() { 3,11,19 };
        private int payoutField1 = 3;
        private int payoutField2 = 11;
        private int payoutField3 = 19;


        public bool IsPayoutLocation(int placeOnField, int lastPlaceOnField)
        {
            return (lastPlaceOnField < payoutField1 && payoutField1 <= placeOnField) ||
                   (lastPlaceOnField < payoutField2 && payoutField2 <= placeOnField) ||
                   (lastPlaceOnField < payoutField3 && payoutField3 <= placeOnField);
        }
    }
}

