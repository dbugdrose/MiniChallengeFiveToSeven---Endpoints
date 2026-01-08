using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCFiveToSeven.Services
{
    public class MCSevenOneServices
    {
        public string ReverseItAlphanumeric(string LettersAndNumbers)
        {
            string ReversedLettersAndNumbers = "";

            bool hasLetter = LettersAndNumbers.Any(char.IsLetter);
            bool hasDigit = LettersAndNumbers.Any(char.IsDigit);

            if (hasDigit && hasLetter)
            {
                for (int i = LettersAndNumbers.Length - 1; i >= 0; i--)
                {
                    ReversedLettersAndNumbers += LettersAndNumbers[i].ToString();
                }
                return $"You entered {LettersAndNumbers}, the reverse of that is {ReversedLettersAndNumbers}.";
            }
            else { return "Please enter a string that has both numbers and letters."; }
        }
    }
}