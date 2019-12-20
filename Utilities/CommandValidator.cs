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
        /*
        Bu sınıfın görevi Command sınıfına gönderilen değerlerin gerçekten istenilen değer türlerinde olup olmadıklarını kontrol etmektir.
        Command komutları string olarak geliyor. Foreach ile içerideki charlar tek tek kontrol edilerek eğer belirtilen LMR harici bir karakter içeriyorsa flag
        değişkenimiz false döneceği için tekrardan veri girişi isteyecektir.
        */

        public static bool Validate(string input)
        {
            bool flag = false;
            int check = 0;
            int L = 76, M = 77, R = 82;
            foreach (char character in input)
            {
                if (Convert.ToInt32(character) == L || Convert.ToInt32(character) == M || Convert.ToInt32(character) == R)
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
