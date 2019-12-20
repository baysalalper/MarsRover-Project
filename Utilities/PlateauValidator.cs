using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
   public class PlateauValidator
    {
        /*
        Bu sınıfın görevi PlateauParameters sınıfına gönderilen değerlerin gerçekten istenilen değer türlerinde olup olmadıklarını kontrol etmektir.
        Dışarıdan alınan veri List<char> tipinde olduğundan dolayı charlar int tipine dönüştürüldüğünde ASCII olarak karşılığını veriyor. Bende burda 
        ASCII tablosundaki değerler ile karşılaştırıp doğruysa True yanlış ise False değeri döndürüyorum.
        */
        public static bool Validate(List<char> input)
        {

            bool flag = false;
            int StartofNumbers = 49, EndofNumbers = 57;
            if(input.Count==2&&
                Convert.ToInt32(input[0])>= StartofNumbers && 
                Convert.ToInt32(input[0]) <= EndofNumbers && 
                Convert.ToInt32(input[1]) >= StartofNumbers && 
                Convert.ToInt32(input[1]) <= EndofNumbers)
            {
                flag = true;
                return flag;
            }
            Console.WriteLine("Girdiğiniz Plateau Değerleri Hatalı Lütfen Tekrar Giriniz");
            return flag;
        }

    }
}
