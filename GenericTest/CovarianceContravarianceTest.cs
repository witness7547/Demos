using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTest
{
    class CovarianceContravarianceTest
    {
        public static void Main()
        {
            Animal animal = new Dog();
            Console.WriteLine(animal);

            Dog dog = new Dog();
            Test(dog);//covariance协变

            //contravariance逆变:cannot convert from Animal to Dog
            //dog = GetAnimal();


            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog());

            List<Dog> dogs = new List<Dog>();
            //dogs.Add(new Animal());
        }

        public static void Test(Animal a) { }

        public static Animal GetAnimal() { return new Animal(); }
    }

    class Animal
    { }

    class Dog : Animal
    { }

    class BlackDog : Dog
    { }
}
