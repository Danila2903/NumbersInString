using System;
using System.Collections.Generic;
using System.Text;

namespace NumbersToLines
{
    public enum NumberRange
    {
        From2To4, // 2/3/4 тысячи, миллиона, миллиарда
        One, // 1 тысяча, миллион, миллиард
        Other, // 5... тысяч, миллионов, миллиардов
    }

    class Storage
    {
        #region От 1 до 20

        #region Именительный падеж
        public static Dictionary<int, string> From1To20ImMale = new Dictionary<int, string>
        {
            {1, "один" },
            {2, "два" },
            {3, "три" },
            {4, "четыре" },
            {5, "пять" },
            {6, "шесть" },
            {7, "семь" },
            {8, "восемь" },
            {9, "девять" },
            {10, "десять" },
            {11, "одиннадцать" },
            {12, "двенадцать" },
            {13, "тринадцать" },
            {14, "четырнадцать" },
            {15, "пятнадцать" },
            {16, "шестнадцать" },
            {17, "семнадцать" },
            {18, "восемнадцать" },
            {19, "девятнадцать" },
        };

        public static Dictionary<int, string> From1To20ImFemale = new Dictionary<int, string>
        {
            {1, "одна" },
            {2, "две" },
        };

        public static Dictionary<int, string> From1To20ImMiddle = new Dictionary<int, string>
        {
            {1, "одно"},
        };

        #endregion

        #region Родительный падеж
        public static Dictionary<int, string> From1To20RodMale = new Dictionary<int, string>
        {
            {1, "одного" },
            {2, "двух" },
            {3, "трех" },
            {4, "четырех" },
            {5, "пяти" },
            {6, "шести" },
            {7, "семи" },
            {8, "восьми" },
            {9, "девяти" },
            {10, "десяти" },
            {11, "одиннадцати" },
            {12, "двенадцати" },
            {13, "тринадцати" },
            {14, "четырнадцати" },
            {15, "пятнадцати" },
            {16, "шестнадцати" },
            {17, "семнадцати" },
            {18, "восемнадцати" },
            {19, "девятнадцати" },
        };

        public static Dictionary<int, string> From1To20RodFemale = new Dictionary<int, string>
        {
            {1, "одной" },
        };

        public static Dictionary<int, string> From1To20RodMiddle = new Dictionary<int, string>();
        
        #endregion

        #region Дательный падеж
        public static Dictionary<int, string> From1To20DatMale = new Dictionary<int, string>
        {
            {1, "одному" },
            {2, "двум" },
            {3, "трем" },
            {4, "четырем" },
            {5, "пяти" },
            {6, "шести" },
            {7, "семи" },
            {8, "восьми" },
            {9, "девяти" },
            {10, "десяти" },
            {11, "одиннадцати" },
            {12, "двенадцати" },
            {13, "тринадцати" },
            {14, "четырнадцати" },
            {15, "пятнадцати" },
            {16, "шестнадцати" },
            {17, "семнадцати" },
            {18, "восемнадцати" },
            {19, "девятнадцати" },
        };

        public static Dictionary<int, string> From1To20DatFemale = new Dictionary<int, string>
        {
            {1, "одной" },
        };

        public static Dictionary<int, string> From1To20DatMiddle = new Dictionary<int, string>();
        #endregion

        #region Винительный падеж
        public static Dictionary<int, string> From1To20VinMale = new Dictionary<int, string>
        {
            {1, "одного" },
            {2, "двух" },
            {3, "трех" },
            {4, "четырех" },
            {5, "пять" },
            {6, "шесть" },
            {7, "семь" },
            {8, "восьмь" },
            {9, "девять" },
            {10, "десять" },
            {11, "одиннадцать" },
            {12, "двенадцать" },
            {13, "тринадцать" },
            {14, "четырнадцать" },
            {15, "пятнадцать" },
            {16, "шестнадцать" },
            {17, "семнадцать" },
            {18, "восемнадцать" },
            {19, "девятнадцать" },
        };

        public static Dictionary<int, string> From1To20VinFemale = new Dictionary<int, string>
        {
            {1, "одну" },
            {2, "две" },
            {3, "три" },
            {4, "четыре" },
            
        };

        public static Dictionary<int, string> From1To20VinMiddle = new Dictionary<int, string>()
        {
            {1, "одно" },
            {2, "два" },
            {3, "три" },
            {4, "четыре" },
        };
        #endregion

        #region Творительный падеж
        public static Dictionary<int, string> From1To20TvMale = new Dictionary<int, string>
        {
            {1, "одним" },
            {2, "двумя" },
            {3, "тремя" },
            {4, "четырьмя" },
            {5, "пятью" },
            {6, "шестью" },
            {7, "семью" },
            {8, "восьмью" },
            {9, "девятью" },
            {10, "десятью" },
            {11, "одиннадцатью" },
            {12, "двенадцатью" },
            {13, "тринадцатью" },
            {14, "четырнадцатью" },
            {15, "пятнадцатью" },
            {16, "шестнадцатью" },
            {17, "семнадцатью" },
            {18, "восемнадцатью" },
            {19, "девятнадцатью" },
        };

        public static Dictionary<int, string> From1To20TvFemale = new Dictionary<int, string>
        {
            {1, "одной" },
        };

        public static Dictionary<int, string> From1To20TvMiddle = new Dictionary<int, string>();
        #endregion

        #region Предложныйпадеж
        public static Dictionary<int, string> From1To20PredMale = new Dictionary<int, string>
        {
            {1, "одном" },
            {2, "двух" },
            {3, "трех" },
            {4, "четырех" },
            {5, "пяти" },
            {6, "шести" },
            {7, "семи" },
            {8, "восьми" },
            {9, "девяти" },
            {10, "десяти" },
            {11, "одиннадцати" },
            {12, "двенадцати" },
            {13, "тринадцати" },
            {14, "четырнадцати" },
            {15, "пятнадцати" },
            {16, "шестнадцати" },
            {17, "семнадцати" },
            {18, "восемнадцати" },
            {19, "девятнадцати" },
        };

        public static Dictionary<int, string> From1To20PredFemale = new Dictionary<int, string>
        {
            {1, "одной" },
        };

        public static Dictionary<int, string> From1To20PredMiddle = new Dictionary<int, string>();
        #endregion

        #endregion

        #region десятки (от 20 до 90)
        /// <summary>
        /// Именительный
        /// </summary>
        public static Dictionary<int, string> From20To100Im = new Dictionary<int, string>
        {
            {20, "двадцать" },
            {30, "тридцать" },
            {40, "сорок" },
            {50, "пятьдесят" },
            {60, "шестьдесят" },
            {70, "семьдесят" },
            {80, "восемьдесят" },
            {90, "девяносто" },
        };

        /// <summary>
        /// Родительный
        /// </summary>
        public static Dictionary<int, string> From20To100Rod = new Dictionary<int, string>
        {
            {20, "двадцати" },
            {30, "тридцати" },
            {40, "сорока" },
            {50, "пятьдесяти" },
            {60, "шестьдесяти" },
            {70, "семьдесяти" },
            {80, "восемьдесяти" },
            {90, "девяноста" },
        };
        /// <summary>
        /// Дательный
        /// </summary>
        public static Dictionary<int, string> From20To100Dat = new Dictionary<int, string>
        {
            {20, "двадцати" },
            {30, "тридцати" },
            {40, "сорока" },
            {50, "пятьдесяти" },
            {60, "шестьдесяти" },
            {70, "семьдесяти" },
            {80, "восемьдесяти" },
            {90, "девяноста" },
        };
        /// <summary>
        /// Винительный
        /// </summary>
        public static Dictionary<int, string> From20To100Vin = new Dictionary<int, string>
        {
            {20, "двадцать" },
            {30, "тридцать" },
            {40, "сорок" },
            {50, "пятьдесять" },
            {60, "шестьдесять" },
            {70, "семьдесять" },
            {80, "восемьдесять" },
            {90, "девяносто" },
        };
        /// <summary>
        /// Творительный
        /// </summary>
        public static Dictionary<int, string> From20To100Tv = new Dictionary<int, string>
        {
            {20, "двадцатью" },
            {30, "тридцатью" },
            {40, "сороками" },
            {50, "пятьюдесятью" },
            {60, "шестьюдесятью" },
            {70, "семьюдесятью" },
            {80, "восемьюдесятью" },
            {90, "девяноста" },
        };
        /// <summary>
        /// Предложный
        /// </summary>
        public static Dictionary<int, string> From20To100Pred = new Dictionary<int, string>
        {
            {20, "двадцати" },
            {30, "тридцати" },
            {40, "сорока" },
            {50, "пятьдесяти" },
            {60, "шестьдесяти" },
            {70, "семьдесяти" },
            {80, "восемьдесяти" },
            {90, "девяноста" },
        };
        #endregion

        #region сотни (от 100 до 900)
        /// <summary>
        /// Именительный
        /// </summary>
        public static Dictionary<int, string> From100To900Im = new Dictionary<int, string>
        {
            {100, "сто" },
            {200, "двести" },
            {300, "триста" },
            {400, "четыреста" },
            {500, "пятьсот" },
            {600, "шестьсот" },
            {700, "семьсот" },
            {800, "восемьсот" },
            {900, "девятьсот" },
        };

        /// <summary>
        /// Родительный
        /// </summary>
        public static Dictionary<int, string> From100To900Rod = new Dictionary<int, string>
        {
            {100, "ста" },
            {200, "двухсот" },
            {300, "трехсот" },
            {400, "четырехсот" },
            {500, "пятисот" },
            {600, "шестисот" },
            {700, "семисот" },
            {800, "восьмисот" },
            {900, "девятисот" },
        };
        
        /// <summary>
        /// Дательный
        /// </summary>
        public static Dictionary<int, string> From100To900Dat = new Dictionary<int, string>
        {
            {100, "ста" },
            {200, "двумстам" },
            {300, "тремстам" },
            {400, "четыремстам" },
            {500, "пятистам" },
            {600, "шестистам" },
            {700, "семистам" },
            {800, "восьмистам" },
            {900, "девятистам" },
        };
        
        /// <summary>
        /// Винительный
        /// </summary>
        public static Dictionary<int, string> From100To900Vin = new Dictionary<int, string>
        {
            {100, "сто" },
            {200, "двести" },
            {300, "триста" },
            {400, "четыреста" },
            {500, "пятьсот" },
            {600, "шестьсот" },
            {700, "семьсот" },
            {800, "восемьсот" },
            {900, "девятьсот" },
        };
        
        /// <summary>
        /// Творительный
        /// </summary>
        public static Dictionary<int, string> From100To900Tv = new Dictionary<int, string>
        {
            {100, "ста" },
            {200, "двумястами" },
            {300, "тремястами" },
            {400, "четырьмястами" },
            {500, "пятьюстами" },
            {600, "шестьюстами" },
            {700, "семьюстами" },
            {800, "восемьюстами" },
            {900, "девятьюстами" },
        };
       
        /// <summary>
        /// Предложный
        /// </summary>
        public static Dictionary<int, string> From100To900Pred = new Dictionary<int, string>
        {
            {100, "ста" },
            {200, "двухстах" },
            {300, "трехстах" },
            {400, "четырехстах" },
            {500, "пятистах" },
            {600, "шестистах" },
            {700, "семистах" },
            {800, "восьмистах" },
            {900, "девятистах" },
        };
        #endregion

        #region тысячи
        public static Dictionary<NumberRange, string> ThousandsIm = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысяча" },
            { NumberRange.From2To4, "тысячи" },
            { NumberRange.Other, "тысяч" },
        };
        
        public static Dictionary<NumberRange, string> ThousandsRod = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысячи" },
            { NumberRange.From2To4, "тысяч" },
            { NumberRange.Other, "тысяч" },
        };

        public static Dictionary<NumberRange, string> ThousandsDat = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысяче" },
            { NumberRange.From2To4, "тысячам" },
            { NumberRange.Other, "тысячам" },
        };

        public static Dictionary<NumberRange, string> ThousandsVin = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысячу" },
            { NumberRange.From2To4, "тысячи" },
            { NumberRange.Other, "тысяч" },
        };

        public static Dictionary<NumberRange, string> ThousandsTv = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысячей" },
            { NumberRange.From2To4, "тысячами" },
            { NumberRange.Other, "тысячами" },
        };


        public static Dictionary<NumberRange, string> ThousandsPred = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "тысяче" },
            { NumberRange.From2To4, "тысячах" },
            { NumberRange.Other, "тысячах" },
        };

        #endregion

        #region миллион

        public static Dictionary<NumberRange, string> MillionsIm = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллион" },
            { NumberRange.From2To4, "миллиона" },
            { NumberRange.Other, "миллионов" },
        };

        public static Dictionary<NumberRange, string> MillionsRod = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиона" },
            { NumberRange.From2To4, "миллионов" },
            { NumberRange.Other, "миллионов" },
        };

        public static Dictionary<NumberRange, string> MillionsDat = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиону" },
            { NumberRange.From2To4, "миллионам" },
            { NumberRange.Other, "миллионам" },
        };

        public static Dictionary<NumberRange, string> MillionsVin = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллион" },
            { NumberRange.From2To4, "миллиона" },
            { NumberRange.Other, "миллионов" },
        };

        public static Dictionary<NumberRange, string> MillionsTv = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллионом" },
            { NumberRange.From2To4, "миллионами" },
            { NumberRange.Other, "миллионами" },
        };

        public static Dictionary<NumberRange, string> MillionsPred = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллионе" },
            { NumberRange.From2To4, "миллионах" },
            { NumberRange.Other, "миллионах" },
        };



        #endregion

        #region миллиард

        public static Dictionary<NumberRange, string> BillionsIm = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиард" },
            { NumberRange.From2To4, "миллиарда" },
            { NumberRange.Other, "миллиардов" },
        };

        public static Dictionary<NumberRange, string> BillionsRod = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиарда" },
            { NumberRange.From2To4, "миллиардов" },
            { NumberRange.Other, "миллиардов" },
        };

        public static Dictionary<NumberRange, string> BillionsDat = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиарду" },
            { NumberRange.From2To4, "миллиардам" },
            { NumberRange.Other, "миллиардам" },
        };

        public static Dictionary<NumberRange, string> BillionsVin = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиард" },
            { NumberRange.From2To4, "миллиарда" },
            { NumberRange.Other, "миллиардов" },
        };

        public static Dictionary<NumberRange, string> BillionsTv = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиардом" },
            { NumberRange.From2To4, "миллиардами" },
            { NumberRange.Other, "миллиардами" },
        };

        public static Dictionary<NumberRange, string> BillionsPred = new Dictionary<NumberRange, string>
        {
            { NumberRange.One, "миллиарде" },
            { NumberRange.From2To4, "миллиардах" },
            { NumberRange.Other, "миллиардах" },
        };

#endregion


    }
}
