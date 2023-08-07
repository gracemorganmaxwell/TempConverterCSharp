using System;

namespace TemperatureConverter
{
    public static class Converter
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Celsius to Fahrenheit Converter 3000");
            Console.WriteLine("I can convert Celsius to Fahrenheit for you. Please enter the temperature in Celsius:");

            if (double.TryParse(Console.ReadLine(), out double celsiusTemperature) && celsiusTemperature >= -271.15)
            {
                double fahrenheitTemperature = (celsiusTemperature * 9 / 5) + 32;
                Console.WriteLine($"The temperature in Fahrenheit is: {fahrenheitTemperature:F2}°F");
            }
            else
            {
                Console.WriteLine("Invalid input or temperature below absolute zero (-271.15°C). Please enter a valid temperature.");
            }
        }
    }
}
