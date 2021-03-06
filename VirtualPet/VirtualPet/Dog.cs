using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Dog : Pet
    {
        //Peso em KG.
        public double Weight { get; set; }
        //Altura em cm.
        public double Height { get; set; }

        public Dog(string name, string color) : base(name, color)
        {
            Weight = 2.0;
            Height = 10.0;
        }

        //Método de alimentar o Pet
        public void comer()
        {
            Weight += 0.5;

            if (Height >= 20)
            {
                Height = Height;
                return;
            }
            Height += 3;
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