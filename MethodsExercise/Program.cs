using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a name:");
            //string name = Console.ReadLine();

            //Console.WriteLine("Please enter a type of animal:");
            //string animal = Console.ReadLine();

            //Console.WriteLine("Please enter a color:");
            //string color = Console.ReadLine();

            //Console.WriteLine("Please enter another name:");
            //string name2 = Console.ReadLine();

            //Console.WriteLine("Please enter a weapon type:");
            //string weapon = Console.ReadLine();

            //Console.WriteLine($"There was once a person named {name}, and they had a {color} pet {animal}.");
            //Console.WriteLine($"They loved their pet, {name2} very much, but one day, {name2} was kidnapped by a scary monster.");
            //Console.WriteLine($"Gathering their courage, {name} took a {weapon} and fought back against the scary monster, saving their pet {name2}");
            //Console.WriteLine($"and living happily ever after.");

            Console.WriteLine("Please input first number to be added:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second number to be added:");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum of those numbers is: {sum}");

            Console.WriteLine("Please input first number to be multiplied:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input second number to be multiplied:");
            num2 = int.Parse(Console.ReadLine());

            int product = Product(num1, num2);
            Console.WriteLine($"The product of those numbers is: {product}");
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;

        }

        public static int Product(int num1, int num2)
        {
            return num1 * num2;

        }
    }
}
