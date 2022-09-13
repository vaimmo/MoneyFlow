using System;
using System.Collections.Generic;
using System.Linq;


namespace Money_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            var Field = new PlayingField();
            //user should 
            var character = new Character("Vadym");

            Console.WriteLine(character.Name);
            var prof1 = Character.CharacterProfessionInfo;
            Console.WriteLine(prof1.ToString());

            Console.WriteLine(prof1.FullIncome);
            Console.WriteLine(prof1.FullExpenses);
            Console.WriteLine(prof1.MoneyFlow);

            for (; ; )
            {
                var a = character.PlaceOnField;
                Console.WriteLine($"Place on field is {a}");

                Field.fields.TryGetValue(a, out string fieldDescription);
                Console.WriteLine(fieldDescription);

                //try to track changes

                var isPayout = character.IsPayout();
                character.IsChariteble();

                Console.WriteLine(isPayout.ToString());

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
