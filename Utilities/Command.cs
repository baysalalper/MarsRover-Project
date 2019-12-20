using MarsRover.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Entities.Rover
{
    public class Command
    {
        public static string ReturnCommand()
        {
            string command;
            bool check=false;
            Console.WriteLine("Rover için Komutları Giriniz.");
            do
            {
                command= Console.ReadLine().ToUpper();
                check = CommandValidator.Validate(command);

            } while (check == false);

            return command;
        }
    }
}
