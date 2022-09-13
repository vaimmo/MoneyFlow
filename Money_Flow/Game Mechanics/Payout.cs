using System;
using System.Collections.Generic;
namespace Money_Flow.GameMechanics
{
    public class Payout
    {
        private readonly int payoutField1 = 3;
        private readonly int payoutField2 = 11;
        private readonly int payoutField3 = 19;


        public bool IsPayoutLocation(int placeOnField, int lastPlaceOnField)
        {
            return (lastPlaceOnField < payoutField1 && payoutField1 <= placeOnField) ||
                   (lastPlaceOnField < payoutField2 && payoutField2 <= placeOnField) ||
                   (lastPlaceOnField < payoutField3 && payoutField3 <= placeOnField);
        }

        public bool IsDoublePayout(int placeOnField, int lastPlaceOnField)
        {
            return (lastPlaceOnField < payoutField1 && payoutField2 <= placeOnField) ||
                   (lastPlaceOnField < payoutField2 && payoutField3 <= placeOnField) ||
                   (lastPlaceOnField < payoutField3 && payoutField1 <= placeOnField);
        }
    }
}

