using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RegularCalculator
    {
        public int Sum(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}