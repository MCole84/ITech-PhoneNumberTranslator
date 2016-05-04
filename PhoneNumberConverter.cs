using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TelephoneNumberConversion
{
    internal class PhoneNumberConverter
    {
        ///private string _stringFormat = @"\(?\d{3}\)?-?*\d{3}-?*-?[0-9a-zA-z]{4}";

        /// <summary>
        /// Converts the letters in the provided phone number into numerical values
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="FormatException">Throws this exception if the input string does not match the format string provided</exception>
        public string ConvertNumber(string number)
        {
            StringBuilder result = new StringBuilder();
            if (!ValidatePhoneNumberFormat(number))
            {
                throw new FormatException("Phone number was not in a proper format.");
            }
            else
            {
                foreach (char num in number.ToLower())
                {
                    switch (num)
                    {
                        case 'a':
                        case 'b':
                        case 'c':
                            result.Append("2");
                            break;

                        case 'd':
                        case 'e':
                        case 'f':
                            result.Append("3");
                            break;

                        case 'g':
                        case 'h':
                        case 'i':
                            result.Append("4");
                            break;

                        case 'j':
                        case 'k':
                        case 'l':
                            result.Append("5");
                            break;

                        case 'm':
                        case 'n':
                        case 'o':
                            result.Append("6");
                            break;

                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                            result.Append("7");
                            break;

                        case 't':
                        case 'u':
                        case 'v':
                            result.Append("8");
                            break;

                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            result.Append("9");
                            break;

                        default:
                            result.Append(num);
                            break;
                    }
                }
            }

            return result.ToString();
        }

        public bool ValidatePhoneNumberFormat(string number)
        {
            bool isValid = true;
            if (number.Length < 12)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if ((i == 3 || i == 7))
                    {
                        if (number[i] != '-')
                        {
                            isValid = false;
                        }
                    }
                    else
                    {
                        if (!char.IsLetterOrDigit(number[i]))
                        {
                            isValid = false;
                        }
                    }
                }
            }
            return isValid;
        }



        /// <summary>
        /// Set the format that will be used to validate strings passed into the ConvertPhoneNumber method before phone numbers are edited
        /// </summary>
        /// <param name="format"></param>
        public
            void SetStringFormat(string format)
        {
        }

        /// <summary>
        /// Creates a new PhoneNumberConverter object with the phone number format set to match 'XXX-XXX-XXXX'
        /// </summary>
        public PhoneNumberConverter()
        {
            
        }
       
    }
}