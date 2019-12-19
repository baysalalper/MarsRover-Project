using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class InputSeperator
    {
        public static List<char> Seperate(string input)
        {
            input = input.Replace(" ", String.Empty);
            List<Char> ch = input.ToCharArray().ToList();
            return ch;

        }

    }
}
