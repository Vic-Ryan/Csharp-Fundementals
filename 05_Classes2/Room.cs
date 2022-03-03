using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes2
{
    public class Room
    {
        public Room() { } //Implicit, but can be inaccessible when another constructor exists

        public Room(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;

        }
        /*
        Create a Room class that has three properties: one each for the length, width, and height.
        Create a method that calculates total square footage.
        We also would like to include some constants that the define a minimum and maximum length, width, and height.
        When setting the properties, make sure to compare the values to the min/max and only set them if the value is valid.

        Bonus:
        Create a method that calculates total lateral surface area.
        Only allow the properties to be set from inside the class itself (Make all set's private, set only in constructor
        Throw an exception if the given value is outside the permitted range.
        Test the code like we did with the Vehicle tests.
        */


        private const double MaxLength = 30;
        private const double MinLength = 6;
        private const double MaxWidth = 40;
        private const double MinWidth = 5;
        private const double MaxHeight = 25;
        private const double MinHeight = 10;

        //Fields
        private double _length;
        private double _width;
        private double _height;


        public double Length
        {
            get { return _length; }
            private set
            { //Compare to max and min before setting
                if (value > MaxLength || value < MinLength)
                {
                    throw new ArgumentException($"Cannot put dimensions outside of length range of {MinLength} and {MaxLength}");
                }
                //Throw an exception if outside the range
                else
                    _length = value;
                    //Throw keyword for programming actions. Throwing an exception returns an error
                
            }
        }

        public double Width
        {
            get { return _width; }
            private set
            {
                if (value > MaxWidth || value < MinWidth)
                {
                    throw new ArgumentException($"Cannot put dimensions outside of width range of {MinWidth} and {MaxLength}");
                }

                else
                    _width = value;
                
            }

        }




        public double Height
        {
            get { return _height; }
            private set
            {
                if (value > MaxHeight || value < MinHeight)
                {
                    throw new ArgumentException($"Cannot put dimensions outside of height range {MinHeight} and {MaxHeight}");
                }
                else
                
                    _height = value;
                
            }
        }
        //Method for square footing

        public double SquareFoot()
        {
            return Length * Width;
        }

        public double LateralArea()
        {
            //double lateralLengthWidth = Length + Width;
            // double lateralHeight = Height * 2;
            //double lateralArea = lateralHeight * lateralLengthWidth;
            //return lateralArea; 

            return 2 * (Height * (Length + Width));
        }
    }
}