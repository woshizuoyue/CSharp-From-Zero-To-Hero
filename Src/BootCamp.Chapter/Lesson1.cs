using System;


namespace BootCamp.Chapter
{
    class Lesson1
    {
        public void Demo()
        {
            Console.WriteLine("Enter the age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Enter the weights: ");
            string weight = Console.ReadLine();
            Console.WriteLine("Enter the heights: ");
            string height = Console.ReadLine();

            Console.WriteLine($"Tom Jefferson is {age} years old, his weight is {weight} kg and his height is {height} cm.");
        }
    }
}
