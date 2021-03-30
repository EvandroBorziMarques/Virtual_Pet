using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Cat : Pet
    {      

        public double Weight { get; set; }
        public double Height { get; set; }

        public Cat(string name, string color) : base(name, color)
        {
            Weight = 1.5;
            Height = 9.0;
        }

        //Método de alimentar o Pet
        public void comer()
        {
            Weight += 0.5;

            if (Height > 20)
            {
                Height = Height;
            }
            Height += 0.5;
        }

        public void passear()
        {
            Weight -= 0.3;
        }

        public void dormir()
        {
            Weight -= 0.1;
        }
    }
}
