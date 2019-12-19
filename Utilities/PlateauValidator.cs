using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
   public class PlateauValidator
    {
        public static bool Validate(List<char> input)
        {
            bool flag = false;

            if(Convert.ToInt32(input[0])>=49 && Convert.ToInt32(input[0]) <= 57 && Convert.ToInt32(input[1]) >= 49 && Convert.ToInt32(input[1]) <= 57)
            {
                flag = true;
                return flag;
            }
            Console.WriteLine("Girdiğiniz Plateau Değerleri Hatalı Lütfen Tekrar Giriniz");
            return flag;
        }

    }
}
