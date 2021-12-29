using System;

namespace Polymorphism
{
    class Bird
    {
        public void fly(double height)
        {
            Console.Write("Flying at {0} feet above sea level", height);
        }

    }

    class Eagle : Bird
    {

        public Eagle()
        {
            fly();
        }
        public void fly()
        {
            Console.Write("Eagle fies at a maximum height of 37,000 feet\n\n");
        }
    }

    class Pigeon : Bird
    {
        public Pigeon()
        {
            fly();
        }
        public void fly()
        {
            Console.Write("Pigeon fies at a maximum height of 7,000 feet\n\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            Pigeon pigeon = new Pigeon();
            Console.ReadLine();
        }
    }
}
