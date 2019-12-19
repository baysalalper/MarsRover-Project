using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Entities
{
    interface IFunctions
    {
        void Move();
        void TurnLeft();
        void TurnRight();
        void Command(string command);
        void Position();
        
    }
}
