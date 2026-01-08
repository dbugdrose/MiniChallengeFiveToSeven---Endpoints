using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MCFiveToSeven.Services
{
    public class MCSixServices
    {
        public string OddOrEven(int num1)
        {
            if (num1 % 2 == 0)
            { return $"The number {num1} is even."; }
            else
            { return $"The number {num1} is odd."; }
        }
    }
}