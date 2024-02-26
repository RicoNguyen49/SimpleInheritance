using System;

namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";
        }

        // parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }


    class Dog : Animal
    {
        // Public fields for dog class 
        public string breed;
        public int age;
        public string color;

        // Default constructor
        public Dog()
        {
            breed = "";
            age = 0;
            color = "";
        }

        // Parameterized constructor
        public Dog(string name, string breed, int age, string color) : base(name)
        {
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        // Method to display dog information
        public void DisplayDogInfo()
        {
            Console.WriteLine("Dog information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Color: {color}");
        }
    }


    class Cat : Animal
    {
        // public fields for Cat class
        public string Breed;
        public int Age;
        public string Color;

        // Default constructor
        public Cat()
        {
            Breed = "";
            Age = 0;
            Color = "";
        }
        // Parameterized constructor
        public Cat(string name, string breed, int age, string color) : base(name)
        {
            this.Breed = breed;
            this.Age = age;
            this.Color = color;
        }

        // Method to display cat information
        public void DisplayCatInfo()
        {
            Console.WriteLine("cat information");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {Breed}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Color: {Color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object of base class
            Animal myPet = new Animal();
            myPet.name = "ruffles";
            myPet.display();
            Console.WriteLine();

            // Object of derived class dog using default constructor
            Dog myDog1 = new Dog();
            myDog1.name = "tido";
            myDog1.breed = "chihuahua";
            myDog1.age = 3;
            myDog1.color = "black and white";
            myDog1.DisplayDogInfo();
            Console.WriteLine();

            // Object of derived class dog using parameterized constructor
            Dog myDog2 = new Dog("Anita", "German Shepherd", 5, "Black and Tan");
            myDog2.DisplayDogInfo();
            Console.WriteLine();


            //object of derived class Cat using default constructor
            Cat myCat1 = new Cat();
            myCat1.name = "tom";
            myCat1.Breed = "Siamese";
            myCat1.Age = 8;
            myCat1.Color = "White";
            myCat1.DisplayCatInfo();
            Console.WriteLine();

            //object of derived class Cat using parameterized constructor
            Cat myCat2 = new Cat("Snowball", "Persian", 4, "Gray");
            myCat2.DisplayCatInfo();
            Console.WriteLine();
        }
    }
}