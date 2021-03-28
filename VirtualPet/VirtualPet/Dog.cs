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
        public int Peso { get; set; }
        //Altura em cm.
        public int Altura { get; set; }

        public Dog(string name, string color)
        {
            Name = name;
            Color = color;
            Peso = 2;
            Altura = 10;
        }

        //Método de alimentar o Pet
        public void comer()
        {
            Peso += 1;            

            if (Altura > 20)
            {
                Altura = Altura;
            }
                Altura += 1;

            return;
        }        
    }
}
