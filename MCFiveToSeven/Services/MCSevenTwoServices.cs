using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCFiveToSeven.Services
{
    public class MCSevenTwoServices
    {
        public string ReverseItNumeric(int numbers)
        {
            string reversedNumbers = "";
            for (int i = numbers.ToString().Length - 1; i >= 0; i--)
            {
                reversedNumbers += numbers.ToString()[i];
            }
            return $"You entered {numbers}, the reverse of that is {reversedNumbers}.";
        }
    }
}