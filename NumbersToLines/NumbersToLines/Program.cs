using System;

namespace NumbersToLines
{
    public enum Gender
    {
        Male,
        Female,
        Middle,
        Unknown
    }

    public enum Case
    {
        Im, Rod, Dat, Vin, Tv, Pred, Unknown
    }

    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter();
            while (true)
            {
                Console.WriteLine("Введите целое число (от 0 до 999 999 999 999)");
                var str1 = Console.ReadLine();
                long num = 0;
                var isNumber = long.TryParse(str1.Replace(" ", ""), out num);
                if (!isNumber)
                {
                    Console.WriteLine("Неверно введено число");
                    continue;
                }

                var cGender = GetGender();
                if (cGender == Gender.Unknown) //some change
                {
                    Console.WriteLine("Неверно введен пол");
                    continue;
                }

                var cCase = GetCase();
                if (cCase == Case.Unknown)
                {
                    Console.WriteLine("Неверно введен падеж");
                    continue;
                }

                var test = converter.ConvertNumberToString(num, cGender, cCase);
                Console.WriteLine($"Прописью {num}: {test}");
                Console.WriteLine("");
            }
            


        }

        public static Gender GetGender()
        {
            Console.WriteLine("Введите пол (формат ввода: \"М\", \"Ж\", \"С\")");
            var str2 = Console.ReadLine();
            Gender cGender = Gender.Unknown;
            str2 = str2.Replace(" ", "");
            if (str2 == "М" || str2 == "м")
                cGender = Gender.Male;
            if (str2 == "Ж" || str2 == "ж")
                cGender = Gender.Female;
            if (str2 == "С" || str2 == "с")
                cGender = Gender.Female;
            return cGender;
        }

        public static Case GetCase()
        {
            Console.WriteLine("Введите падеж (формат ввода: \"И\", \"Р\", \"Д\", \"В\", \"Т\", \"П\")");
            var str2 = Console.ReadLine();
            str2 = str2.Replace(" ", "");
            Case cCase = Case.Unknown;
            if (str2 == "И" || str2 == "и")
                cCase = Case.Im;
            if (str2 == "Р" || str2 == "р")
                cCase = Case.Rod;
            if (str2 == "Д" || str2 == "д")
                cCase = Case.Dat;
            if (str2 == "В" || str2 == "в")
                cCase = Case.Vin;
            if (str2 == "Т" || str2 == "т")
                cCase = Case.Tv;
            if (str2 == "П" || str2 == "п")
                cCase = Case.Pred;
            return cCase;
        }
    }
}
