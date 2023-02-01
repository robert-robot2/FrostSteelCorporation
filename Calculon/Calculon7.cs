using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FrostSteelCorporation.Calculon.Enums;
using FrostSteelCorporation.Calculon.Models;

namespace FrostSteelCorporation.Calculon
{
    public class Calculon7
    {
        public NumberPiece[,] Calc7 { get; set; }

        public NumberStyle ClearCalc = NumberStyle.Zero;

        public static int finalResult1;
        public static int numberSource;
        public static int numberSource2;
        
        
        
        
        public static string clearNumbers;
        public static int decimalNumbers;
     
        public static void AddNumbers1()
        {
            finalResult1 = numberSource + numberSource2;
        }

        public static void SubtractNumbers1()
        {
            finalResult1 = numberSource - numberSource2;
        }

        public static void DivideNumbers1()
        {
            finalResult1 = numberSource / numberSource2;
        }

        public static void MultiplyNumbers1()
        {
            finalResult1 = numberSource * numberSource2;
        }

        public static void AllNumbers(int Number)
        {
            
            numberSource = Number;
        }
        public static void AllNumbers2(int Number2)
        {
            numberSource2 = Number2;
            
        }
        public static void DecimalNumbers()
        {
            

        }
        public static void EqualsNumbers()
        {

        }



        public static void ClearNumbers()
        {
     
            clearNumbers = (Convert.ToDouble(numberSource= 0)).ToString();
            clearNumbers = (Convert.ToDouble(numberSource2 = 0)).ToString();
            clearNumbers = (Convert.ToDouble(finalResult1 = 0)).ToString();
        }

      




    }
}
