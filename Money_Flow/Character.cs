using System;
using Money_Flow.Professions;
using Money_Flow.GameMechanics;

namespace Money_Flow
{
    public class Character
    {
        private readonly Payout payout = new();
        private readonly Charitable charitable = new();

        public Character(string name)
        {
            this.name = name;
            placeOnField = 0;
            CharProfession();
            Money = randomCharacter.Savings;
        }

        //character name
        public string Name => name;

        public string name;

        //character profession
        public static string Profession => randomCharacter.Career; 

        public static AbstractCharacter randomCharacter;

        public double Money { get; set; }

        //get children count 
        public int Children => children;

        private int children;

        //increase maximum to 3 children per one character
        public int MaxChildren()
        {
            if (children < 3)
            {
                return children += 1;
            }

            return children;
        }

        //Filds about character's plays on the field
        public int PlaceOnField { get => StepCalculate(); }

        private int placeOnField;

        private int lastPlaceOnField;

        public int doubleDice;

        private static AbstractCharacter CharProfession()
        {
            var random = new Random();

            var a = random.Next(12);
            //implement random proffesions method
            return a switch
            {
                0 => randomCharacter = new Constructor(),
                1 => randomCharacter = new Doctor(),
                2 => randomCharacter = new Doorman(),
                3 => randomCharacter = new Lawyer(),
                4 => randomCharacter = new Mecanist(),
                5 => randomCharacter = new Nurse(),
                6 => randomCharacter = new OfficeManager(),
                7 => randomCharacter = new Pilot(),
                8 => randomCharacter = new PoliceOfficer(),
                9 => randomCharacter = new Secretary(),
                10 => randomCharacter = new Teacher(),
                11 => randomCharacter = new TrackDriver(),
                _ => throw new NotImplementedException(),
            };

        }

        private readonly Randomizer random = new();

        private int StepCalculate()
        {
            var dice = random.Dice();

            if (doubleDice != 0)
            {
                dice += random.Dice();               
                Console.WriteLine($"Double dice gives you {dice} moves");
                doubleDice -= 1;
            }

            else Console.WriteLine($"Dice gives you {dice} moves");
            
            var nextField = placeOnField + dice;

            if (nextField < 24)
            {
                lastPlaceOnField = placeOnField;
                placeOnField = nextField;
                return placeOnField;
            }
            else
            {
                lastPlaceOnField = placeOnField;
                placeOnField = nextField - 24;
                return placeOnField;
            }
        }

        public double AddIncome()
        {
            Console.WriteLine("Payout " + randomCharacter.MoneyFlow);

            return Money += randomCharacter.MoneyFlow;
        }

        public double IsPayout()
        {
            if (doubleDice != 0 && payout.IsDoublePayout(placeOnField, lastPlaceOnField))
            {
                Console.WriteLine("Double payout");
                return Money += (2 * randomCharacter.MoneyFlow);
            }
            else
            {
                return payout.IsPayoutLocation(placeOnField, lastPlaceOnField) ? AddIncome() : Money;
            }
        }

        public double IsChariteble()
        {
            if (charitable.IsCharitableField(placeOnField))
            {
                Console.WriteLine("Do you want to charitable 10% off al you money?");
                Console.WriteLine("To accept press 'y', \nto refuse press 'n'");
                var choice = Convert.ToString(Console.ReadLine());
                if (choice == "y")
                {
                    doubleDice = 3;
                    return Money *= 0.9;
                }
            }
            return Money;
        }
    }
}
