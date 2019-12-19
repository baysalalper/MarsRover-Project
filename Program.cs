using MarsRover.Entities.Rover;
using MarsRover.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
       
        static void Main()
        {

            Plateau plateau = PlateauParameters.PlateauCreator();
            Rover rover1 = RoverParameters.RoverCreator(plateau);
            rover1.Command(Command.ReturnCommand());
            Rover rover2 = RoverParameters.RoverCreator(plateau);
            rover2.Command(Command.ReturnCommand());
            rover1.Position();
            rover2.Position();
            Console.ReadKey();

        }

        
    }
}
