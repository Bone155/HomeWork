using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    public class Animal
    {
        //Declase and initialize a Simple Value Type variable of type int.
        public int numberOfLegs = 4;
        //Just Declare a string variable (without initializing)
        public string says;
        //Declare a Method for this class.
        //methods provide functionality for your code to execute.
        //More on this later.
        public void Speak()
        {
            Console.WriteLine(says);
        }
    }

    public class Dog : Animal
    {
        public Dog()
        {
            says = "woof";
        }
    }
    public class Cat : Animal
    {
        public Cat()
        {
            says = "meow";
        }
    }
    class Program
    {

        static void Main(string[] args)
        {

            Dog bonzo = new Dog();// Declare and Initialize a Dog.
            Cat felix = new Cat();
            bonzo.Speak();// Do a thing
            felix.Speak();
            Console.ReadKey();//Wait for user input.

        }
    }

}
