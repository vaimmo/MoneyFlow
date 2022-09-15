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

            Console.WriteLine("Income {0}", prof1.FullIncome);
            Console.WriteLine("Expenses {0}",prof1.FullExpenses);
            Console.WriteLine("Money Flow {0}", prof1.MoneyFlow);

            for (; ; )
            {
                Console.WriteLine(prof1.Career);

                var a = character.PlaceOnField;
                Console.WriteLine($"Place on field is {a}");

                Field.fields.TryGetValue(a, out string fieldDescription);
                Console.WriteLine(fieldDescription + " fiels");

                var isPayout = character.AddIncome();

                character.IsChariteble();

                Console.WriteLine($"Now you have {character.Money} $");

                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
