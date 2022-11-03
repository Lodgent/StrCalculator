using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        public StringCalculator()
        {

        }

        public int Add(string numbers)
        {
            if (numbers == "")
                return 0;
            return numbers.Split(",").Select(x => int.Parse(x)).Sum();
        }
    }
}