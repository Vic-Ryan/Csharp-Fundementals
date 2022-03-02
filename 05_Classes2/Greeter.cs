using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes2
{
    public class Greeter
    {
        //Fields are usually put at the top
        Random _random = new Random();

        //Parts of a method
        //1 Access Modifier 
        //2 Return type = What does this method give me?
        //3 Method Name
        //4  Method Parameters. Name+Parameters = Method signature. name(parameters)
        //5 Body, what's being executed when called?


        //1     2      3         4
        public void SayHello(string name)
            //Void returns back nothing
        {
            //5
            Console.WriteLine($"{RandomGreeting()}, {name}");
        }
        //Overloaded method
        //Same method, different parameters
        public void SayHello()
        {
            Console.WriteLine("What's up homie?");
        }
        
        public void SayHello(int highFives)
        {
            Console.WriteLine($"Hey! Give me {highFives} high fives!");
        }

        public void GetRandomGreeting()
        {
            string[] availableGreetings = new string[]
                {"Hello", "Wazzzzzup", "Yo, my dude", "Hi!", "Salutations"}; //Can also be typed as string[] availableGreetings = {array here};
            int randomNumber = _random.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            //ElementAt is used to get and display a certain value. Could also be typed as: string randomGreeting = availableGreetings[randomNumber];
            Console.WriteLine($"{randomGreeting}");
        }

        public string RandomGreeting()
        {
            string[] availableGreetings = new string[]
                {"Hello", "Wazzzzzup", "Yo, my dude", "Hi!", "Salutations"}; //Can also be typed as string[] availableGreetings = {array here};
            int randomNumber = _random.Next(0, availableGreetings.Length);
            string randomGreeting = availableGreetings.ElementAt(randomNumber);
            //ElementAt is used to get and display a certain value. Could also be typed as: string randomGreeting = availableGreetings[randomNumber];
            return randomGreeting;
        }
    }
}
