using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_10
{
    class ugol
    {
        float gradus;
        float min;
        float sec;

        public float Gradus
        {
            get
            {
                return gradus;
            }
            set
            {
                if(value<0)
                    {
                    Console.WriteLine("Значение не корректно");
                }
                else
                {
                    gradus = value;
                }

            }
        }
        public float Min
        {
            get
            {
                return min;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение не корректно");
                }
                else
                {
                   min = value;
                }

            }
        }
        public float Sec
        {
            get
            {
                return sec;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение не корректно");
                }
                else
                {
                    sec = value;
                }

            }
        }

        public ugol(float gradus, float min, float sec)
        {
            this.Gradus = gradus;
            this.Min = min;
            this.Sec = sec;
        }
       public float ToRadians()
        {
            return ( sec /  206265 + min / 3438 + gradus / 57);
        }
    }
}
