// //First Challenge
// Console.WriteLine("kilometer to Miles = 1 \nMiles to kilometer = 2");
// int user = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please Enter the distance");
// int killoMiles = Convert.ToInt32(Console.ReadLine());

// if (user == 1) {
//     Killometer(killoMiles);
// } else if (user == 2) {
//     Miles(killoMiles);
// }

// void Killometer (int Killometer) {
//         Console.WriteLine(Killometer * 0.621371);

// }
// void Miles (int Miles) {
//         Console.WriteLine(Miles * 1.60934);
// }


// Second Challenge
// String pass = Console.ReadLine();
// checkpass(pass);
// void checkpass(String pass) {
//     if (pass.Length < 8) {
//         Console.WriteLine("password length < 8 ");
//     } else if (!pass.Any(char.IsUpper)) {
//         Console.WriteLine("password don't have uppercase");
//     } else {
//         Console.WriteLine("Passed: " + pass);
//     }
// }


//Third Challenege Degree 
//     Console.WriteLine("Choose a conversion option:\n" +
//         "1: Fahrenheit to Celsius\n" +
//         "2: Fahrenheit to Kelvin\n" +
//         "3: Kelvin to Fahrenheit\n" +
//         "4: Kelvin to Celsius\n" +
//         "5: Celsius to Fahrenheit\n" +
//         "6: Celsius to Kelvin");

//     int userChoice = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter the degree:");
//     double degree = Convert.ToDouble(Console.ReadLine());

//     switch (userChoice)
//     {
//         case 1:
//             Console.WriteLine("Fahrenheit to Celsius = " + FahrenheitToCelsius(degree));
//             break;
//         case 2:
//             Console.WriteLine("Fahrenheit to Kelvin = " + FahrenheitToKelvin(degree));
//             break;
//         case 3:
//             Console.WriteLine("Kelvin to Fahrenheit = " + KelvinToFahrenheit(degree));
//             break;
//         case 4:
//             Console.WriteLine("Kelvin to Celsius = " + KelvinToCelsius(degree));
//             break;
//         case 5:
//             Console.WriteLine("Celsius to Fahrenheit = " + CelsiusToFahrenheit(degree));
//             break;
//         case 6:
//             Console.WriteLine("Celsius to Kelvin = " + CelsiusToKelvin(degree));
//             break;
//         default:
//             Console.WriteLine("Invalid option.");
//             break;
//     }

// static double FahrenheitToCelsius(double fahrenheit)
// {
//     return (fahrenheit - 32) * 5 / 9;
// }

// static double FahrenheitToKelvin(double fahrenheit)
// {
//     return (fahrenheit - 32) * 5 / 9 + 273.15;
// }

// static double KelvinToFahrenheit(double kelvin)
// {
//     return (kelvin - 273.15) * 9 / 5 + 32;
// }

// static double KelvinToCelsius(double kelvin)
// {
//     return kelvin - 273.15;
// }

// static double CelsiusToFahrenheit(double celsius)
// {
//     return (celsius * 9 / 5) + 32;
// }

// static double CelsiusToKelvin(double celsius)
// {
//     return celsius + 273.15;
// }


//Forth Challenge Sum
//     Console.Write("Enter the number of Array: ");
//     int size = Convert.ToInt32(Console.ReadLine());

//     int[] numbers = new int[size];

//     PopulateArray(numbers);

//     int sum = CalculateSum(numbers);

//     Console.WriteLine($"The sum of the entered numbers is: {sum}");
// static void PopulateArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Enter number {i + 1}: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// static int CalculateSum(int[] array)
// {
//     int sum = 0;
//     foreach (int num in array)
//     {
//         sum += num;
//     }
//     return sum;
// }





using System.Drawing;

using System;

// class Color {
//     public string Pritness { get; set; }
//     public string Number { get; set; }
//     public string Name { get; set; }

//     public void PrintMessage() {
//         Console.WriteLine("message");
//     }
// }

// class Program { 
//     public static void Main(string[] args) {
//         Color myMessage = new Color();
//         myMessage.PrintMessage();
//     }
// }


using System;

class Water {
    public string weight { get; set; }
    public string type { get; set; }
    public string sodium { get; set; }
    public string calcium { get; set; }

    public Water(string weight, string type, string sodium, string calcium) {
        this.weight = weight;
        this.type = type;
        this.sodium = sodium;
        this.calcium = calcium;
    }

    public void PrintWaterType() {
        Console.WriteLine($"Weight: {weight}\nType: {type}\nSodium: {sodium}\nCalcium: {calcium}");
    }
}

class Output {
    public static void Main(string[] args) {
        Water newWater = new Water("200ml", "Berain", "13mg", "10mg");
        newWater.PrintWaterType(); 
    }
}
///test