using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToLines
{
    class Converter
    {
        private Dictionary<Case, Dictionary<Gender, Dictionary<int, string>>> from1To20GenderCase;

        private Dictionary<Case, Dictionary<int, string>> from20To90Case;
        private Dictionary<Case, Dictionary<int, string>> from100To900Case;

        private Dictionary<Case, Dictionary<NumberRange, string>> thousandsCase;
        private Dictionary<Case, Dictionary<NumberRange, string>> millionsCase;
        private Dictionary<Case, Dictionary<NumberRange, string>> billionsCase;

        public Converter()
        {
            InitializeDigits();
            InitializeDecades();
            InitializeOthers();
        }

        public string ConvertNumberToString(long number, Gender cGender, Case cCase)
        {
            var result = "";
            var nSumCopy = number;
            var digits = new int[4];
            for (int i = 0; i < digits.Length; i++)
            {
                int lastDigit = (int)(nSumCopy % 1000);
                digits[i] = lastDigit;
                nSumCopy /= 1000;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    var threeDigits = "";
                    var numberRange = GetNumberRange(digits[i]);
                    switch (i)
                    {
                        case 1:
                            threeDigits = GetThreeDigitsInString(digits[i], Gender.Female, cCase);

                            threeDigits += thousandsCase[cCase][numberRange] + " ";
                            break;
                        case 2:
                            threeDigits = GetThreeDigitsInString(digits[i], Gender.Male, cCase);

                            threeDigits += millionsCase[cCase][numberRange] + " ";
                            break;
                        case 3:
                            threeDigits = GetThreeDigitsInString(digits[i], Gender.Male, cCase);

                            threeDigits += billionsCase[cCase][numberRange] + " ";
                            break;
                        case 0:
                            threeDigits = GetThreeDigitsInString(digits[i], cGender, cCase);

                            break;
                        default:
                            break;
                    }
                    result = result.Insert(0, threeDigits);
                }
            }
            return result;
        }

        private NumberRange GetNumberRange(int num)
        {
            var ones = num % 10; //разряд единиц
            var decades = (num % 100) / 10; //разряд десятков
            if (decades == 1)
                return NumberRange.Other; //если 1N, то всегда будет тысяч, миллионов, миллиардов
            if (ones == 1)
                return NumberRange.One; //если последняя 1, то возвращаем это
            if (ones >= 2 && ones <= 4)
                return NumberRange.From2To4;
            return NumberRange.Other;
        }

        private string GetThreeDigitsInString(int digits, Gender cGender, Case cCase)
        {
            var result = "";
            var hundreds = digits / 100;
            hundreds *= 100;
            var lack = digits % 100;
            if (hundreds != 0)
                result += from100To900Case[cCase][hundreds] + " ";
            if (lack != 0)
            {
                if (lack < 20)
                {
                    //result += from1To20GenderCase[cCase][cGender][lack] + " ";
                    if (from1To20GenderCase[cCase][cGender].ContainsKey(lack))
                        result += from1To20GenderCase[cCase][cGender][lack] + " ";
                    else if (from1To20GenderCase[cCase][Gender.Male].ContainsKey(lack)) //ищем аналогичный в мужском (универсальном)
                        result += from1To20GenderCase[cCase][Gender.Male][lack] + " ";
                }
                else
                {
                    var decades = lack / 10;
                    decades *= 10;
                    var ones = lack % 10;
                    if (from20To90Case[cCase].ContainsKey(decades))
                    {
                        result += from20To90Case[cCase][decades] + " ";
                    }
                    if (from1To20GenderCase[cCase][cGender].ContainsKey(ones))
                        result += from1To20GenderCase[cCase][cGender][ones] + " ";
                    else if (from1To20GenderCase[cCase][Gender.Male].ContainsKey(ones)) //ищем аналогичный в мужском (универсальном)
                        result += from1To20GenderCase[cCase][Gender.Male][ones] + " ";
                }
            }
            return result;
        }
        private void InitializeDigits()
        {
            from1To20GenderCase = new Dictionary<Case, Dictionary<Gender, Dictionary<int, string>>>
            {
                {
                    Case.Im, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20ImMale},
                            {Gender.Female, Storage.From1To20ImFemale},
                            {Gender.Middle, Storage.From1To20ImMiddle},
                        }
                },
                {
                    Case.Rod, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20RodMale},
                            {Gender.Female, Storage.From1To20RodFemale},
                            {Gender.Middle, Storage.From1To20RodMiddle},
                        }
                },
                {
                    Case.Dat, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20DatMale},
                            {Gender.Female, Storage.From1To20DatFemale},
                            {Gender.Middle, Storage.From1To20DatMiddle},
                        }
                }, 
                {
                    Case.Vin, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20VinMale},
                            {Gender.Female, Storage.From1To20VinFemale},
                            {Gender.Middle, Storage.From1To20VinMiddle},
                        }
                }, 
                {
                    Case.Tv, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20TvMale},
                            {Gender.Female, Storage.From1To20TvFemale},
                            {Gender.Middle, Storage.From1To20TvMiddle},
                        }
                }, 
                {
                    Case.Pred, new Dictionary<Gender, Dictionary<int, string>>
                        {
                            {Gender.Male, Storage.From1To20PredMale},
                            {Gender.Female, Storage.From1To20PredFemale},
                            {Gender.Middle, Storage.From1To20PredMiddle},
                        }
                },
            };
        }

        private void InitializeDecades()
        {
            from20To90Case = new Dictionary<Case, Dictionary<int, string>>
            {
                {Case.Im, Storage.From20To100Im},
                {Case.Rod, Storage.From20To100Rod},
                {Case.Dat, Storage.From20To100Dat},
                {Case.Vin, Storage.From20To100Vin},
                {Case.Tv, Storage.From20To100Tv},
                {Case.Pred, Storage.From20To100Pred},
            };
        }

        private void InitializeOthers()
        {
            from100To900Case = new Dictionary<Case, Dictionary<int, string>>
            {
                {Case.Im, Storage.From100To900Im },
                {Case.Rod, Storage.From100To900Rod},
                {Case.Dat, Storage.From100To900Dat},
                {Case.Vin, Storage.From100To900Vin},
                {Case.Tv, Storage.From100To900Tv},
                {Case.Pred, Storage.From100To900Pred},
            };

            thousandsCase = new Dictionary<Case, Dictionary<NumberRange, string>>
            {
                {Case.Im, Storage.ThousandsIm },
                {Case.Rod, Storage.ThousandsRod},
                {Case.Dat, Storage.ThousandsDat},
                {Case.Vin, Storage.ThousandsVin},
                {Case.Tv, Storage.ThousandsTv},
                {Case.Pred, Storage.ThousandsPred},
            };
            millionsCase = new Dictionary<Case, Dictionary<NumberRange, string>>
            {
                {Case.Im, Storage.MillionsIm },
                {Case.Rod, Storage.MillionsRod},
                {Case.Dat, Storage.MillionsDat},
                {Case.Vin, Storage.MillionsVin},
                {Case.Tv, Storage.MillionsTv},
                {Case.Pred, Storage.MillionsPred},
            };
            billionsCase = new Dictionary<Case, Dictionary<NumberRange, string>>
            {
                {Case.Im, Storage.BillionsIm },
                {Case.Rod, Storage.BillionsRod},
                {Case.Dat, Storage.BillionsDat},
                {Case.Vin, Storage.BillionsVin},
                {Case.Tv, Storage.BillionsTv},
                {Case.Pred, Storage.BillionsPred},
            };
        }

    }
}
