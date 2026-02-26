using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Serialization;
namespace COMP003A.Assignment7
{
    internal class Program
    { // Student Score Analyzer. This program is a collection fo student scores and allows the user to display scores
      // and calculate them when needed.
		static void Main(string[] args)
		{
           List<int> scores = new List<int>(); //This is the list storing student scores.
           scores.Add(92);
           scores.Add(74);
		   scores.Add(83);
		   scores.Add(79);
		   scores.Add(99);

            Console.WriteLine("1. Display Student Score"); // This is the menu that introduces the user to the options.
            Console.WriteLine("2. Show Total");
            Console.WriteLine("3. Show Class Average");
			Console.WriteLine("4. Exit Program");

			bool program = true;
            while (program) 
            {
                Console.Write("\nEnter Valid Choice: ");
            
            
                try //The try-catch block prevents crash if user puts ina  non-numeric input.
                {
                    int choice = int.Parse(Console.ReadLine());

                    if (choice < 0 || choice > 4) 
                    {
                        Console.WriteLine("\nERROR: Invalid menu option. You must choose 1-4.");
                    }


                else if (choice == 1) { DisplayScores(scores); }
                    else if (choice == 2) { DisplayTotal(scores); }
                    else if (choice == 3) { DisplayAverage(scores); }
                    else if (choice == 4) { program = false; Console.WriteLine("Program ended."); }

                }
                catch (FormatException) { Console.WriteLine("Invalid input. Please enter a number."); } }
       }
        static void DisplayScores(List<int> scores)
        {
            Console.WriteLine("\nScores");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
        }
        static void DisplayTotal(List<int> scores)
        {
            int total = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                total += scores[i];
            }
            Console.WriteLine($"\nTotal: {total}");
        }
        static void DisplayAverage(List<int> scores)
        {
            int total = 0;
            for (int i = 0; i < scores.Count; i++) { total += scores[i]; }

            double average = (double)total / scores.Count;
            Console.WriteLine($"\nAverage: {average}");
        }
    }
}
