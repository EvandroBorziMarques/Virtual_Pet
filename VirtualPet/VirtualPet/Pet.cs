using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Pet(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
