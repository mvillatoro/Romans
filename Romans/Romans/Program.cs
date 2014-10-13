using System;

namespace Romans
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ToRoman(234));
            Console.Read();
        }

        public static string ToRoman(int number)
        {
            String[] ones = {"","I","II","III","IV","V","VI","VII","VIII","IX"};
            String[] tens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            String[] hundreds = {"","C","CC","CCC","CD","D","DC","DCC","DCCC","CM"};
            //String[] thousands = {"","M","MM","MMM"};

            var arabic = number;
            var o = arabic%10;
            var t = (arabic/10)%10;
            var h = (arabic/100)%10;
           // var z = arabic/2;

            //if(arabic>=1000)
            //    return thousands[z]+hundreds[h]+tens[t]+ones[o];  

            if(arabic>=100)           
                return hundreds[h]+tens[t]+ones[o];  
              
            if(arabic>=10)  
                return tens[t]+ones[o];            
            
            return ones[o];                                          
        }
    }
}