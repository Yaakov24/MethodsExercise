using System;
using System.ComponentModel.Design;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[]args)
                                  
        {
            Add();
            Console.WriteLine(Addition(4, 5));
            Console.WriteLine(Subtraction(50, 40));
            Console.WriteLine(Multiplication(200, 4));
            Console.WriteLine(AutomaticNumbers(5, 4, 3, 2, 1));
        }
        public static void Add() {
            Console.WriteLine("Hey whats your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hey whats your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("Hey whats your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Hey whats your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"{name} was walking to the {color} restaurant and on the way \n" +
                $" he saw a/an {animal} run by. He got to the restaurant and ate, then left.\n" +
                $" Then as he was walking down the sidewalk, he saw a concert being set up with \n" +
                $"the {band} then he went there and had a blast!");

           
        }
        public static int Addition(int num1, int num2) {
            int solution = num1 + num2;
            return solution;
        }
        public static int Subtraction(int num1, int num2)
        {
            int solution1 = num1 - num2;
            return solution1;
        }
        public static int Multiplication(int num1, int num2)
        {
            int solution2 = num1 * num2;
            return solution2;
        }
        public static int? AutomaticNumbers(params int[] numbers)
        {

            int sum = 0;
            
            foreach (int num in numbers)
            {
                
                sum = sum + num;
                
            }
            return sum;
        }
    }
    };
   


