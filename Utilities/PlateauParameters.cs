using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Utilities
{
    class PlateauParameters
    {
        public static Plateau PlateauCreator()
        {
            bool check = false;
            List<char> plateuSize;

            do
            {
                plateuSize = InputSeperator.Seperate(Console.ReadLine());
                check = PlateauValidator.Validate(plateuSize);
            } while (check == false);
            
           
            Plateau plateau = new Plateau((int)char.GetNumericValue(plateuSize[0]), (int)char.GetNumericValue(plateuSize[1]));
            return plateau;
            
            

        }

       
    }
}
