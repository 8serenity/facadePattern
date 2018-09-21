using System;
using System.Threading;
using System.Threading.Tasks;

namespace FacedePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method to use for Facede Pattern
            ProcessOrder();

            Console.Read();
        }

        private static async Task ProcessOrder()
        {
            var food = AskUserForFood();
            var address = AskUserForAddress();
            await CookFood(food);
            await DeliverFood(address);
            Console.WriteLine("Your order is ready. Thanks for choosing us!");
        }

        private static Task DeliverFood(string address)
        {
            Console.WriteLine($"Delivering food to address: {address}");
            return Task.Run(() =>
            {
                Thread.Sleep(500);

                Console.WriteLine($"Delivering food to address: {address}");
                Thread.Sleep(1500);
                Console.WriteLine($"Traffic jam...");
                Thread.Sleep(500);
                Console.WriteLine($"Almost came to {address}");
                Thread.Sleep(500);
            });

        }

        private static Task CookFood(string food)
        {
            return Task.Run(() =>
            {
                Thread.Sleep(500);

                Console.WriteLine("Cooking meal");
                Thread.Sleep(500);
                Console.WriteLine("Cooking meal. Please Wait");
                Thread.Sleep(500);
                Console.WriteLine("Cooking meal");
                Thread.Sleep(500);
            });

        }

        private static string AskUserForFood()
        {
            Console.WriteLine("What food would you like to order?");
            return Console.ReadLine();
        }
        private static string AskUserForAddress()
        {
            Console.WriteLine("Tell us your address please");
            return Console.ReadLine();
        }
    }
}