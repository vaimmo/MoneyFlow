using System;
using System.Collections.Generic;

namespace Money_Flow
{
    public class PlayingField
    {
        //First circle have 24 filds
        //Second circle have 48 filds
        public PlayingField()
        {
            fields.Add(0, "Opportunity");
            fields.Add(1, "Market");
            fields.Add(2, "Opportunity");
            fields.Add(3, "Payout");
            fields.Add(4, "Opportunity");
            fields.Add(5, "Dismissal");
            fields.Add(6, "Opportunity");
            fields.Add(7, "Small expenses");
            fields.Add(8, "Opportunity");
            fields.Add(9, "Market");
            fields.Add(10, "Opportunity");
            fields.Add(11, "Payout");
            fields.Add(12, "Opportunity");
            fields.Add(13, "Child");
            fields.Add(14, "Opportunity");
            fields.Add(15, "Small expenses");
            fields.Add(16, "Opportunity");
            fields.Add(17, "Market");
            fields.Add(18, "Opportunity");
            fields.Add(19, "Payout");
            fields.Add(20, "Opportunity");
            fields.Add(21, "Charitable");
            fields.Add(22, "Opportunity");
            fields.Add(23, "Small expenses");
        }

        public Dictionary<int, string> fields = new Dictionary<int, string>();
    }
}

