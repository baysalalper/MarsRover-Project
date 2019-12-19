using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
    public class CommandValidator
    {
        public static bool Validate(string input)
        {
            bool flag = false;
            int check = 0;
            foreach (char character in input)
            {
                if (Convert.ToInt32(character) == 76 || Convert.ToInt32(character) == 77 || Convert.ToInt32(character) == 82)
                {
                    check++;
                }
            }

            if (input.Count() == check)
            {
                flag = true;
                return flag;
            }
            Console.WriteLine("Girilen Komutlar Hatalı Lütfen Tekrar Giriniz");
            return flag;
        }

    }
}
