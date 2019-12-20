using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Entities.Rover;
using MarsRover;
using MarsRover.Utilities;

namespace MarsRover.Entities.Rover
{
    public class RoverParameters
    {
        /*
         Bu Sınıfın görevi Program.cs tarafından oluşturulacak olan Rover nesnesinin dışardan verilerini alarak önce RoverValidator sınıfında kontrole
         göndermek ardından ise veriler doğru ise gerekli atamaları gerekli Propertylere gönderek instance alma işlemini tamamlamak.Eğer yanlış veri girilir ise
         Validator sınıfı false göndereceği için doğru değer gönderilene ve check değişkeni true olana kadar veri alma işlemeni yapmaya devam edecektir.


         */
        public static MarsRover.Rover RoverCreator(Plateau plateau)
        {
            bool check=false;
            List<char> RoverCoordinates=null;
            Console.WriteLine("Rover Parametrelerini Giriniz");
            while (check == false) 
            {
                RoverCoordinates = InputSeperator.Seperate(Console.ReadLine());
                check = RoverValidator.Validate(RoverCoordinates);
            } 

                int x = (int)char.GetNumericValue(RoverCoordinates[0]);
                RoverCoordinates.RemoveAt(0);
                int y = (int)char.GetNumericValue(RoverCoordinates[0]);
                RoverCoordinates.RemoveAt(0);

                string direction = Convert.ToString(RoverCoordinates[0]);
                MarsRover.Rover rover = new MarsRover.Rover(x, y, direction, plateau);

                return rover;
        }

    }
}
