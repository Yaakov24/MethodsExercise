namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
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
