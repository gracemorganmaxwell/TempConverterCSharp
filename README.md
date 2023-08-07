# Temp Converter in C Sharp
Given a temperature in Celsius degrees, converts it to Fahrenheit degrees.

## Solution Explained: 

Namespace and Class: enclosed the program inside a namespace called TemperatureConverter and named the class Converter. This is a standard practice in C# to logically group related code together.

Main Method: This is the entry point of the program. Execution starts here.

Console.WriteLine: This method is used to display messages on the console. Used to greet the user and give instructions.

double.TryParse: This method attempts to convert the user's input (a string) into a double (a numeric data type that can hold decimal numbers). If the conversion is successful, it returns true and assigns the converted number to the celsiusTemperature variable. Otherwise, it returns false.

If Statement: this is used to check two conditions: whether the conversion was successful and whether the temperature is above absolute zero (-271.15°C). If both conditions are true, we proceed to the conversion. Otherwise, we display an error message.

Conversion Formula: To convert Celsius to Fahrenheit, the formula: Fahrenheit=(Celsius×95)+32Fahrenheit=(Celsius×59)+32 is utilised.

String Interpolation: The $ before the string allows for the embed variables or expressions directly inside the string. {fahrenheitTemperature:F2} means displaying the fahrenheitTemperature value will be with 2 decimal places.

## Note: 
Created and run locally in Visual Studio 2022 (free) and using version 7.0 of C Sharp. 
