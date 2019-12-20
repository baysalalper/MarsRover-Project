using MarsRover.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsRover
{
    /*
     Rover Sınıfı Rover Nesnemizi temsil ediyor. IFunctionsdan kalıtım alıyor bu sayede hareket fonksiyonlarının içini Rover'ın hareketine göre  dolduruyoruz.
     Aynı zamanda Rover'ın X ve Y koordinatlarını içeriyor. Sınıfın kurucu fonksiyonununda ise dışarıdan gönderilen x y ve doğrultu değişkenleri gerekli propertylere
     atanıyor.
     Position fonksyionu ise Rover'ın Position fonksiyonunun çağırıldığı andaki konum bilgisini Console'a yazdırıyor.

         */
    public class Rover:IFunctions
    {
        private int xCoordinate;
        private int yCoordinate;
        private string direction;
        private Plateau plateau;


        public int Xcoordinate
        {
            get { return xCoordinate; }
        }

        public int YCoordinate
        {
            get { return yCoordinate; }

        }
        public string Direction
        {
            get { return direction; }
        }

        public Rover(int x, int y, string direction, Plateau plateau)
        {
            direction = direction.ToUpper();

            if (x >= 0 && y >= 0 && x <= plateau.X && y <= plateau.Y)
            {
                this.xCoordinate = x;
                this.yCoordinate = y;
            }
            else
            {
                Console.WriteLine("Girilen değerler uygun değildir");
            }
            if (direction == "N" || direction == "S" || direction == "E" || direction == "W")
            {
                this.direction = direction;
            }
            else
            {
                Console.WriteLine("Girilen Doğrultu Yanlış");
            }

            this.plateau = plateau;
        }


        public void Move()
        {
            switch (direction)
            {
                case "N":
                    if (yCoordinate < plateau.Y)
                    {
                        yCoordinate++;
                    }
                    else { Console.WriteLine("N Doğrultusunda Sınıra Gelinmiştir."); }
                    break;

                case "S":
                    if (yCoordinate < plateau.Y && yCoordinate >= 0)
                    {
                        yCoordinate--;
                    }
                    else { Console.WriteLine("N Doğrultusunda Sınıra Gelinmiştir."); }
                    break;

                case "E":
                    if (xCoordinate < plateau.X)
                    {
                        xCoordinate++;
                    }
                    else { Console.WriteLine("E Doğrultusunda Sınıra Gelinmiştir."); }
                    break;

                case "W":
                    if (xCoordinate < plateau.X && xCoordinate >= 0)
                    {
                        xCoordinate--;
                    }
                    else { Console.WriteLine("E Doğrultusunda Sınıra Gelinmiştir."); }
                    break;

            }



        }

        public void TurnLeft()
        {
            bool check = false;

            switch (direction)
            {
                case "N":
                    if (check !=true)
                    {
                        direction = "W";
                        check = true;
                    }
                    break;

                case "S":
                    if (check != true)
                    {
                        direction = "E";
                        check = true;
                    }
                    break;

                case "E":
                    if (check != true)
                    {
                        direction = "N";
                        check = true;
                    }
                    break;

                case "W":
                    if (check != true)
                    {
                        direction = "S";
                        check = true;
                    }
                    break;
            }
        }

        public void TurnRight()
        {
            bool check = false;

            switch (direction)
            {
                case "N":
                    if (check != true)
                    {
                        direction = "E";
                        check = true;
                    }
                    break;

                case "S":
                    if (check != true)
                    {
                        direction = "W";
                        check = true;
                    }
                    break;

                case "E":
                    if (check != true)
                    {
                        direction = "S";
                        check = true;
                    }
                    break;

                case "W":
                    if (check != true)
                    {
                        direction = "N";
                        check = true;
                    }
                    break;
            }
        }

        public void Command(string command)
        {
            foreach (char item in command)
            {
                switch (item)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                }
              
            }
            
        }

        public void Position()
        {
            Console.WriteLine($"{xCoordinate} {YCoordinate} {direction}");
        }

    }

   
}
