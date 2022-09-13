using System;
using System.Collections.Generic;
using System.Linq;

namespace Money_Flow
{
    public class Randomizer
    {
        readonly Random random = new(); //randomizer

        public List<int> usedCards; // list of used numbers from 1 to 100

        private int randomCard;

        public int RandomCard(int number)
        {
            if (usedCards == null)
            {
                randomCard = random.Next(number);

                usedCards = new();

                usedCards.Add(randomCard);

                return randomCard;
            }

            else
            {
                do
                {
                    randomCard = random.Next(number);
                }

                while (usedCards.Any(i => i.Equals(randomCard)));

                usedCards.Add(randomCard);

                if (usedCards.Count == number)
                {
                    //WriteList();
                    usedCards = null;
                }

                return randomCard;
            }
        }


        public int Dice()
        {
            return random.Next(1, 7);
        }

        //private void WriteList()
        //{
        //    usedCards.ForEach(i => Console.WriteLine(i)); 
        //}
    }
}

// Same class Max's edition!
//public class ClassI
//{
//    private readonly Random _random = new Random(); //randomizer
//    private readonly List<int> _usedCards; // list of used numbers

//    public Class1(int capacity = 100)
//    {
//        _usedCards = new List<int>(capacity);
//        var i = 0;
//        _usedCards.ForEach(uc => i++);
//    }

//    public int GetRandonCard()
//    {
//        if (_usedCards.Count == 0)
//            throw new IndexOutOfRangeException(); //TODO
//        return GetRandomAndRemove(_usedCards);
//    }

//    private int GetRandomAndRemove(List<int> cards)
//    {
//        var index = _random.Next(_usedCards.Count);
//        var element = _usedCards[index];
//        _usedCards.RemoveAt(index);
//        return element;
//    }
//}
