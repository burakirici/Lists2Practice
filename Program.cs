using System;

class Program
{
    public static void Main(string[] args)
    {
        List<string> coffeeList = new List<string>();
        string userCoffeeInfo;

        for (int i = 0; i < 5; i++)
        {
            Console.Write($" Enter Coffee {i + 1} : ");
            userCoffeeInfo = Console.ReadLine();
            coffeeList.Add(userCoffeeInfo);
        }

        Console.WriteLine("Coffee Name List : ");
        foreach (string coffee in coffeeList)
        {
            Console.WriteLine(coffee);
        }
    }
}