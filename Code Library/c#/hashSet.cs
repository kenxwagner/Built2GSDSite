using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input array that contains three duplicate strings.
        string[] array1 =
        {
            "Ford",
            "Dodge",
            "Honda",
            "Toyota",
            "Porsche",
            "Audi",
			"Volvo"
        };

        // Displays an array.
        Console.WriteLine(string.Join(",", array1));

        // Here is the HashSet constructor because of unique strings.
        var hash = new HashSet<string>(array1);

        // Convert to array of strings.
        string[] array2 = hash.ToArray();

        // Display the new array.
        Console.WriteLine(string.Join(",", array2));
    }
}
