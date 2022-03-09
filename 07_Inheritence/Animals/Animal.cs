using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public enum DietType { Herbivore = 1, Carnivore, Omnivore}
   
    public abstract class Animal
    { //Cannot be instantiated on it's own
        //Can only be drived by child classes
        public Animal()
        {
            Console.WriteLine("This is the animal constructor");
            //Base empty consturctor still gets called
        }


        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType Diet { get; set; }
        //Virtual: Can be overridden by a derived class  (A child class can override it)
        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
}
