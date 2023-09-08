using System;

class UnitConverter
{

    static void Main(string[] args)
    {
        while (true) 
        {
            Console.WriteLine("Welcome to the Unit Converter ");
            Console.WriteLine("Please select from one of the following options");
            Console.WriteLine("1. Kilometers to Miles");
            Console.WriteLine("2. Kilograms to Pounds");
            Console.WriteLine("3. Celsius to Fahrenheit");
            String input = Console.ReadLine();

            //Validate user input
            if (input == "1")
            {
                KilometersToMiles();
            }
            else if (input == "2") 
            {
                KilogramsToPounds();
            }
            else if (input == "3")
            {
                CelsiusToFahrenheit();
            }
            else 
            {
                Console.WriteLine("Invalid input. Please try again."); 
            }
        }
    }
    static void KilometersToMiles()
    {
        Console.WriteLine("Please enter the number of kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double miles = kilometers / 1.609344;
        Console.WriteLine(" {0} kilometers is equal to {1} miles.", kilometers, miles);
    }
    
    static void KilogramsToPounds()
    {
        Console.WriteLine("Please enter the number of Kilograms: ");
        double kilograms = double.Parse(Console.ReadLine());
        double pounds = kilograms / 0.45359237;
        Console.WriteLine("{0} kilograms is equal to {1} pounds.", kilograms, pounds);

    }

    static void CelsiusToFahrenheit()
    {
        Console.WriteLine("Please enter the number of Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius / 33.8;
        Console.WriteLine("{0} degrees celsius is equal to {1} degrees fahrenheit.", celsius, fahrenheit);


    }
}