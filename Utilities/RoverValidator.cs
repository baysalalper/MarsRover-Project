using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
    public class RoverValidator
    {
        

        public static bool Validate(List<char> input)
        {
            bool flag = false;
            if(Convert.ToInt32(input[0])>= 49 && Convert.ToInt32(input[0]) <= 57 && Convert.ToInt32(input[1]) >= 49 && Convert.ToInt32(input[1]) <= 57)
            {
                if( Convert.ToInt32(input[2]) == 69 || 
                    Convert.ToInt32(input[2]) == 78 || 
                    Convert.ToInt32(input[2]) == 83 || 
                    Convert.ToInt32(input[2]) == 87 ||
                    Convert.ToInt32(input[2]) == 101 ||
                    Convert.ToInt32(input[2]) == 110 ||
                    Convert.ToInt32(input[2]) == 115 ||
                    Convert.ToInt32(input[2]) == 119 

                    )
                {
                    flag = true;
                    return flag;
                }
            }
            Console.WriteLine("Hatalı Rover Parametresi Girdiniz Lütfen Tekrar Deneyiniz");
            return flag;

        }

    }
}
