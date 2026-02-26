using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Serialization;
namespace COMP003A.Assignment7
{
    internal class Program
    { // Student Score Analyzer 
		static void Main(string[] args)
		{
           List<int> scores = new List<int>();
           scores.Add(92);
           scores.Add(74);
		   scores.Add(83);
		   scores.Add(79);
		   scores.Add(99);

            Console.WriteLine("1. Display Student Score");
            Console.WriteLine("2. Show Total");
            Console.WriteLine("3. Show Class Average");
			Console.WriteLine("4. Exit Program");

			bool program = true;
            while (program)
            {
                Console.Write("Enter Valid Choice: ");
            }
            try
            {
                int choice = int.Parse(Console.ReadLine());

                if (choice < 0 || choice > 4) ;
                { 
                    Console.WriteLine("ERROR: Invalid menu option. You must choose 1-4.");
                }
                else if (choice == 1) { DisplayScores(scores); }
				else if (choice == 2) { DisplayTotal(scores); }
				else if (choice == 3) { DisplayAverage(scores); }
				else if (choice == 4) { program = false Console.WriteLine("Program ended."); }
			}
             catch (FormatException) { Console.WriteLine("Invalid input. Please enter a number."); }
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
            Console.WriteLine($"Total: " + total);
        }
        
    }
}
