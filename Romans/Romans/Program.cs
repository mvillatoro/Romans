using System;
using System.Runtime.Serialization.Formatters;

namespace Romans
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(ToRoman(234));
            Console.WriteLine(ToArabic("IV"));
            Console.WriteLine("************************");
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
            var arab = 0;
            const int i = 1;
            const int v = 5;
            const int x = 10;
            const int l = 50;
            const int c = 100;
            const int d = 500;

            for (var j = 0; j < roman.Length; j++)
            {


                if (roman[j] == 'I')
                {
                    if (j+1<roman.Length)
                    {
                        if (roman[j+1]=='V')
                        {
                            arab += 4;
                        }
                        else if (roman[j + 1] == 'X')
                        {
                            arab += 9;
                        }
                    }
                    else
                    {
                        arab += i;                        
                    }
                }
                else if (roman[j] == 'V')
                {
                    if (j-1>0)
                    {
                        if (roman[j - 1] == 'I')
                        {
                            arab += 0;
                        }    
                    }
                    else
                    {
                        arab += v;
                        
                    }
                }
                else if (roman[j] == 'X')
                {
                    if (j-1>0)
                    {
                        if (roman[j - 1] == 'I')
                        {
                            arab += 0;
                        }   
                    }
                    else
                    {
                        arab += x;         
                    }
                }
                else if (roman[j] == 'L')
                {
                    arab += l;
                }

                else if (roman[j] == 'C')
                {
                    arab += c;
                }

                else if (roman[j] == 'D')
                {
                    arab += d;
                }
                
            }
            return arab;
        }
    }
}