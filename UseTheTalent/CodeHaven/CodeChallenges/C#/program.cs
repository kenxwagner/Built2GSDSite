using System;
namespace KennewickPractice
{  
  class Program
  {
      static void Main()
      {
        double runningTotal = 0;
        bool keepGoing = true;
        
        while (keepGoing)
        {
          //Prompt user for minutes exercised
          Console.Write("Enter the minutes exercised or type \"quit\" to exit: ");
          string entry = Console.ReadLine();
          
          if (entry.ToLower() == "quit")
          {
            //Repeat until user quits
         break;
          }
          else
          {
                     
            try
            {
              double minutes = doublein.Parse(entry);
              if (minutes <=0)
            {
              Console.WriteLine(minutes + " is not an useful value.");
              continue;
            }
            
            if (minutes <= 10)
              
            {
              Console.WriteLine("Better than nothing, know what I'm sayin?");
            }
            else if (minutes <= 30)
            {
              Console.WriteLine("That looks good on you!");
            }
            else if (minutes <= 60)
            {
                  Console.WriteLine("Dang! You just might be a warrior!");
            }
            else 
            {
              Console.WriteLine("Ahem... showing off, are we?");
            }
                          
            
       
          //Add minutes exercised to total
          runningTotal = runningTotal + minutes;
            }
            
            catch(FormatException)
            {
              Console.WriteLine("That is not valid input.");
              
            }
            
            
          //Display total minutes exercised to screen
                        
          Console.WriteLine("You have exercised for " + runningTotal + " minutes");

          }
        }
        Console.WriteLine("Goodbye");
        
      }
  }
}