using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritence.Animals
{
    public class Bear : Animal
    {
        public Bear()
        {
            Console.WriteLine("Creating bear");
            IsMammal = true;
            Diet = DietType.Carnivore;
            HasFur = true;
            NumberOfLegs = 4;
        }
        public bool IsAngry { get; set; }
        public bool IsHibernating { get; set; }
        public string FurColor { get; set; }

        public virtual void Roar()
        {
            Console.WriteLine("The bear roars!");
        }
    }

    public class PolarBear : Bear
    {
        public PolarBear()
        {
            Console.WriteLine("Adding ice");
            FurColor = "White";
        }

        public override void Roar()
        {
            Console.WriteLine("THe polar bear roars and youi can see it's breath!");
        }
    }
}
