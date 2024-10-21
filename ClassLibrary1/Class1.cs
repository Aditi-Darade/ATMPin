using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DebitCard
    {
        public string pin;
        public string Pin
        {
            set
            {
                if (value != "")
                {

                    if (value.Length == 4 || value.Length == 6)
                    {
                        for (int i = 0; i < value.Length; i++)
                        {
                            if (value[i] < 48 || value[i] > 57) //ASCII codes 48 to 57 are equal to digits (0 to 9)
                            {
                                System.Console.WriteLine("Pin cannot have alphabets, please enter a Pin with only digits.");
                                break;
                            }
                            else
                            {
                                pin = value;
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("The Pin should be exactly 4 digits or 6 digits.");
                    }

                }
                else
                {
                    System.Console.WriteLine("Please enter the PIN.");
                }                
            }
            get
            {
                return pin;
            }
        }
    }
}
