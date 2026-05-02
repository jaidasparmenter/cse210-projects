using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        

        Console.Write("Enter numbers, type 0 to stop: ");       // This starts my program and asks a question.
        
        List<int> numb = new List<int>();                       // This defines numb as a list. I can now recall it
        
        int number;                                             // Necessarry bc I'm not sure if there's another way to do it.


    // This is my loop to continue adding onto the list.
        do
        {
            Console.Write("Enter number: ");

            number = int.Parse(Console.ReadLine());

             if (number !=0)
            {
                numb.Add(number);
                                              
            }

        } while (number !=0);

        int sum = 0;
        float avg = 0;
        int max = 0;

        foreach (int item in numb)                              // Found out you can reuse a word if its not defined above it. 
        {
            sum += item;
            avg = ((float)sum) / numb.Count;
            
            if (item>max)
            {
                max = item;
            }

        }



        // This reprints the whole list when you're done
        
        Console.WriteLine($"Your sum is: {sum}");
        Console.WriteLine($"Your average is: {avg}");
        Console.WriteLine($"Your largest number is: {max}");

        Console.WriteLine("Here is your list: ");

        foreach (int item in numb)
        {
            Console.WriteLine(item);
        }

    }
}
