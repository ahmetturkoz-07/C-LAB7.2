using System;

public class Animal
{
    public string Name;
    public int Age;

    public Animal(string animalName, int animalAge)
    {
        Name = animalName;
        Age = animalAge;

        Console.WriteLine("Animal constructor");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}


public class Dog : Animal
{
    public string Breed;

    public Dog(string dogName, int dogAge, string dogBreed)
        : base(dogName, dogAge)
    {
        Breed = dogBreed;

        Console.WriteLine("Dog constructor");
    }

    public void Fetch()
    {
        Console.WriteLine($"{Name} brings the ball back!");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Karabas", 3, "Kangal");

        dog.Eat();
        dog.Fetch();

        Console.WriteLine($"{dog.Name} ({dog.Breed}), {dog.Age} years old");
    }
}

