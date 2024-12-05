using System;

class Program
{
    static void Main(string[] args)
    {

        string passengerName = "Zara";
        int passengerAge = 28;
        string ticketType = "First Class";
        string preferredPlanet = "Mars";

        Console.WriteLine(passengerName);
        Console.WriteLine(passengerAge);
        Console.WriteLine(ticketType);
        Console.WriteLine(preferredPlanet);

        passengerAge++;

        Console.WriteLine(passengerAge);

        double passengerAgeDouble = (double)passengerAge;
        Console.WriteLine(passengerAgeDouble);

        

    }
}

// Console.WriteLine() prints text to the console.
// Console.ReadLine() captures user input in the console.

