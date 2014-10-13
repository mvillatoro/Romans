using System;

namespace Romans
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ToRoman(234));
            Console.WriteLine(ToArabic("X"));
            Console.Read();
        }

        public static string ToRoman(int number)
        {
            String[] ones = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            String[] tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
            String[] hundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
            //String[] thousands = {"","M","MM","MMM"};

            var arabic = number;
            var o = arabic%10;
            var t = (arabic/10)%10;
            var h = (arabic/100)%10;
            // var z = arabic/2;

            //if(arabic>=1000)
            //    return thousands[z]+hundreds[h]+tens[t]+ones[o];  

            if (arabic >= 100)
                return hundreds[h] + tens[t] + ones[o];

            if (arabic >= 10)
                return tens[t] + ones[o];

            return ones[o];
        }

        public static int ToArabic(string roman)
        {
            int arab = 0;
            int i = 1;
            int v = 6;
            int x = 10;
            int l = 50;
            int c = 100;
            int d = 500;

            for (int j = 0; j <= roman.Length; j++)
            {

                if (roman[j]== 'I' || roman[j]== 'i')
                {
                    if (roman[j+1] == 'V' || roman[j+1] == 'v')
                    {
                        arab += 4;
                    }
                    else if (roman[j+1] == 'X' || roman[j+1] == 'x')
                    {
                        arab += 9;
                    }
                    else
                    {
                        arab += i;   
                    }
                }
                if (roman[j] == 'V' || roman[j] == 'v')
                {
                    if (j - 1 != 0)
                    {
                        if (roman[j - 1] == 'I' || roman[j - 1] == 'i')
                        {
                            arab += 0;
                        }       
                    }
                    else
                    {
                        arab += v;   
                    }
                }
                if (roman[j] == 'X' || roman[j] == 'x')
                {
                    if (j - 1 != 0)
                    {
                        if (roman[j - 1] == 'I' || roman[j - 1] == 'i')
                        {
                            arab += 0;
                        }    
                    }
                    else if (roman[j + 1] == 'L' || roman[j+1] == 'l')
                    {
                        arab += 40;
                    }
                    else if (roman[j + 1] == 'C' || roman[j + 1] == 'c')
                    {
                        arab += 90;
                    }
                    else
                    {
                        arab += x;   
                    }
                }
                if (roman[j] == 'L' || roman[j] == 'l')
                {
                    arab += l;
                }
                if (roman[j] == 'C' || roman[j] == 'c')
                {

                    if (j - 1 != 0)
                    {
                        if (roman[j - 1] == 'X' || roman[j - 1] == 'x')
                        {
                            arab += 0;
                        }   
                    }
                    else if(roman[j+1] == 'D' || roman[j+1] == 'd')
                    {
                        arab += 400;
                    }
                    else
                    {
                        arab += c;                        
                    }
                }
                if (roman[j] == 'D' || roman[j] == 'd')
                {

                    if (j - 1 != 0)
                    {
                        if (roman[j - 1] == 'C' || roman[j - 1] == 'c')
                        {
                            arab += 0;
                        }   
                    }
                    else
                    {
                        arab += d;         
                    }
                }
            }

            return arab;
        }
    }
}