﻿namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Story();
            Console.WriteLine(Adding(1, 2));
            Console.WriteLine(Multiplying(10, 2));
            Console.WriteLine(Add(10, 10, 10, 10));
        }
        public static int Adding(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplying(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Add(int num1, int num2, int num3, int num4)
        {
            return num1 + num2 + num3 + num4;
        }
        public static void Story() { 
        Console.WriteLine("Hey what is your name?");
            string name = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
        Console.WriteLine("whats your favorite animal?");
            string animal = Console.ReadLine();
        Console.WriteLine("Whats your favorite band?");
              string band = Console.ReadLine();


        Console.WriteLine($"{name} was walking past a {color} store and he saw on the\n" +
               $"street all set up {band}, then a {animal} walked past, that was fun!");

            }
    }
};
