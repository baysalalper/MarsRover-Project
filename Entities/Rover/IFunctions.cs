using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Entities
{
    /*
     Burada Rover sınfının hareket fonksiyonlarını Interface'e çevirdim. Bunu yapmamın nedeni, ileride Rover haricinde başka bir araç içinde hareket 
     fonksiyonları yazmak istediğimizde direk bu Interface'ten Inheritance aldırarak bu işi daha kolay yapabilecek olmamdı.Basic hareket fonksiyonlarının hepsini
     içeriyor.

         */
    interface IFunctions
    {
        void Move();
        void TurnLeft();
        void TurnRight();
        void Command(string command);
        void Position();
        
    }
}
