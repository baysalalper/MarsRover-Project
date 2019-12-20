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
        /*
         Bu Sınıf Rover.Command fonksiyonuna komutlar gönderilmeden önce karakterleri büyük harfe çevirerek ardından CommandValidator'a kontrole gönderiyor.
         Eğer girilen değerler doğru ise de command stringini Rover içindeki Command fonksiyonuna göndermek üzere program.cs e geri dönrüyor.

             */
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
