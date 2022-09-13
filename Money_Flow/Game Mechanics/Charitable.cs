using System;
namespace Money_Flow.GameMechanics
{
    public class Charitable
    {
        private readonly int charitableField = 21;

        public bool IsCharitableField(int placeOnField)
        {
            return (placeOnField == charitableField);
        }
    }
}

