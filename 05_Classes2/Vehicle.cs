using System;

namespace _05_Classes2
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat }
    //Struct: A type of class that has a default form, structure | Assembly: The solution file, keeping track of all the projects inside
    //Account types:
    //Public: available throughout the full assembly
    //Private: only available in the same class or struct
    //Protected: likke private but also accessible by derived classes
    //Protected Internal: Accessible in this assembly only and derived classes in other assemblies
    //Private Protected: Only in this class, by code in the same class, and derived classes
    public class Vehicle // (Nouns)
    {
        //Constructor
        public Vehicle() {
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }  //Implicit

        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            VehicleType = type;
            LeftIndicator = new Indicator();
            RightIndicator = new Indicator();
        }

        //Fields, Constructors, Properties (Adjectives), and Methods (Verbs)

        //1 Acces modified = Where can this be seen?
        //2 Type = What type of property is it?
        //3 Name = What's it called?
        //4 Getters and Setters = How do I set it? How do I get it?

        //1      2      3       4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public VehicleType VehicleType { get; set; }

        public bool IsRunning { get; private set; }

        public Indicator RightIndicator { get; set; }
        public Indicator LeftIndicator { get; set; }

        public void TurnOn()
        {
            IsRunning = true;
            Console.WriteLine("You turn on the vehicle");
        }

        public void TurnOff()
        {
            IsRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        public void Drive()
        {
            if (IsRunning)
            {
                Console.WriteLine("You start driving the vehicle");
            }
            else
            {
                Console.WriteLine("You need to turn on the vehicle");
            }
        }

        public void IndicateRight()
        {
            RightIndicator.IndicatorOn();
            LeftIndicator.IndicatorOff();
        }
        public void IndicateLeft()
        {
            RightIndicator.IndicatorOff();
            LeftIndicator.IndicatorOn();
        }
        public void ClearIndicators()
        {
            RightIndicator.IndicatorOff();
            LeftIndicator.IndicatorOff();
        }
        public void TurnOnHazards()
        {
            RightIndicator.IndicatorOn();
            LeftIndicator.IndicatorOn();
        }

    }

    public class Indicator
    {
        public bool IsFlashing { get; private set; }

        public void IndicatorOn()
        {
            IsFlashing = true;
            //Console.WriteLine("Your inidcators are on");
        }
        public void IndicatorOff()
        {
            IsFlashing = false;
            //Console.WriteLine("Your indicators are off.");
        }

        /*public void Turn()
        {
            if (IsFlashing)
            {
                Console.WriteLine("You are safe to turn");
            }
            else
            {
                Console.WriteLine("Turn on your indicators before turning");
            }
        }*/
    }
}
