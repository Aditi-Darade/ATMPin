using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec9_Assign24_ATMPin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DebitCard card = new DebitCard();
            System.Console.WriteLine(card.Pin = "1y56");
            //card.Pin = 9999;
            System.Console.ReadKey();
        }
    }
}
