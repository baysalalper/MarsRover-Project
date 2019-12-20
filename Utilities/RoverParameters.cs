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
        public static MarsRover.Rover RoverCreator(Plateau plateau)
        {
            bool check=false;
            List<char> RoverCoordinates;
            Console.WriteLine("Rover Parametrelerini Giriniz");
            do
            {
                RoverCoordinates = InputSeperator.Seperate(Console.ReadLine());
                check = RoverValidator.Validate(RoverCoordinates);
            } while (check == false);

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
