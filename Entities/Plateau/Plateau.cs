using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Plateau
    {
        /*
         Plateau nesnemiz plato için gerekli olan maximum X ve Y değerlerini alarak bizim hareket alanımızı tanımlıyor.
         
             */
        private int x;
        private int y;
        public Plateau(int x,int y)
        {
            if(x>0 && y > 0)
            {
                this.x = x;
                this.y = y;
            }
            else
            {
                Console.WriteLine("Verilen Koordinatlar Geçersiz!");
            }
        }
        

        public int X
        {
            get { return x; }
            
        }
        

        public int Y
        {
            get { return y; }
            
        }

        


    }
}
