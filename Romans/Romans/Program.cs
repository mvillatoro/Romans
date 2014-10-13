using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Romans
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ToRoman(900));
            Console.Read();
        }

        public static string ToRoman(int number)
        {
            const string rnumeral = "";

            if (number < 10)
            {
                return string.Concat(rnumeral, LessThan10(number));
            }
            if (number < 100)
            {
                return string.Concat(rnumeral, LessThan100(number));   
            }
            if (number<1000)
            {
                return string.Concat(rnumeral, LessThan1000(number));
            }
            
            return string.Concat(rnumeral, "Ingrese numero menor a 1000");
        }

        public static string LessThan10(int number)
        {
            if (number == 1)
                return "I";
            if (number == 2)
                return "II";
            if (number == 3)
                return "III";
            if (number == 4)
                return "IV";
            if (number == 5)
                return "V";
            if (number == 6)
                return "VI";
            if (number == 7)
                return "VII"; 
            if (number == 8)
                return "VIII";
            else
            {
                return "IX";
            }
        }

        public static string LessThan100(int number)
        {
            if (number == 10)
                return "X";
            if (number == 20)
                return "XX";
            if (number == 30)
                return "XXX";
            if (number == 40)
                return "XL";
            if (number == 50)
                return "L";
            if (number == 60)
                return "LX";
            if (number == 70)
                return "LXX";
            if (number == 80)
                return "LXXX";
            else
            {
                return "XC";
            }
        }

        public static string LessThan1000(int number)
        {
            if (number == 100)
                return "C";
            if (number == 200)
                return "CC";
            if (number == 300)
                return "CCC";
            if (number == 400)
                return "CD";
            if (number == 500)
                return "D";
            if (number == 600)
                return "DC";
            if (number == 700)
                return "DCC";
            if (number == 800)
                return "DCCC";
            else
            {
                return "CM";
            }
        }
    }
}


//while (N>0) 
//{ 
//resto=N%10; 
//N=N/10; 
//imprimir(resto); 
//}