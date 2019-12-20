using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class InputSeperator
    {
        /*
         Bu Sınıf dışardan veri alındığında eğer kullanıcı araya whitespace yani boşluk eklediyse bu boşukları kaldırmak.
         Aradaki boşluklar kaldırılıktan sonra List<char> değişkeni tamamen girilen parametreleri içeriyor.
         
         */
        public static List<char> Seperate(string input)
        {
            input = input.Replace(" ", String.Empty);
            List<Char> ch = input.ToCharArray().ToList();
            return ch;

        }

    }
}
