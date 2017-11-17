using System;

class Program
{
    enum Importance
    {
        None,
        Minimal,
        Average,
        Important,
        Critical
    };

    static void Main()
    {
        // ... An enum local variable to play with
        Importance value = Importance.Critical;

        // ... Test against known Importance values.
        if (value == Importance.Minimal)
        {
            Console.WriteLine("Not true");
        }
        else if (value == Importance.Critical)
        {
            Console.WriteLine("True");
        }
    }
}