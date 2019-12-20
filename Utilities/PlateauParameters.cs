using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
    class PlateauParameters
    {
        /*
         Bu Sınıfın görevi Program.cs tarafından oluşturulacak olan Plateau nesnesinin dışardan verilerini alarak önce PlateauValidator sınıfında kontrole
         göndermek ardından ise veriler doğru ise gerekli atamaları gerekli Propertylere gönderek instance alma işlemini tamamlamak.Eğer yanlış veri girilir ise
         Validator sınıfı false göndereceği için doğru değer gönderilene ve check değişkeni true olana kadar veri alma işlemeni yapmaya devam edecektir.


         */
        public static Plateau PlateauCreator()
        {
            bool check = false;
            List<char> plateuSize=null;
            Console.WriteLine("Plato Parametrelerini Giriniz");

            while (check == false) 
            {
                plateuSize = InputSeperator.Seperate(Console.ReadLine());
                check = PlateauValidator.Validate(plateuSize);
            } 
            
           
            Plateau plateau = new Plateau((int)char.GetNumericValue(plateuSize[0]), (int)char.GetNumericValue(plateuSize[1]));
            return plateau;
            
            

        }

       
    }
}
