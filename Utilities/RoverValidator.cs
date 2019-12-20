using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
    public class RoverValidator
    {
        /*
         Bu sınıfın görevi RoverParameters sınıfına gönderilen değerlerin gerçekten istenilen değer türlerinde olup olmadıklarını kontrol etmektir.
         Dışarıdan alınan veri List<char> tipinde olduğundan dolayı charlar int tipine dönüştürüldüğünde ASCII olarak karşılığını veriyor. Bende burda 
         ASCII tablosundaki değerler ile karşılaştırıp doğruysa True yanlış ise False değeri döndürüyorum.

             */

        public static bool Validate(List<char> input)
        {
            bool flag = false;
            int StartofNumbers = 49,
                EndofNumbers = 57,
                UpperE=69,
                UpperN=78,
                UpperS=83,
                UpperW=87,
                LowerE=101,
                LowerN=110,
                LowerS=115,
                LowerW=119;


            if(input.Count==3 &&Convert.ToInt32(input[0])>= StartofNumbers && 
                Convert.ToInt32(input[0]) <= EndofNumbers && 
                Convert.ToInt32(input[1]) >= StartofNumbers &&
                Convert.ToInt32(input[1]) <= EndofNumbers 
                )
            {
                if (Convert.ToInt32(input[2]) == UpperE ||
                    Convert.ToInt32(input[2]) == UpperN ||
                    Convert.ToInt32(input[2]) == UpperS ||
                    Convert.ToInt32(input[2]) == UpperW ||
                    Convert.ToInt32(input[2]) == LowerE ||
                    Convert.ToInt32(input[2]) == LowerN ||
                    Convert.ToInt32(input[2]) == LowerS ||
                    Convert.ToInt32(input[2]) == LowerW
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
