// See https://aka.ms/new-console-template for more information

/* Benjamin Costello
   1/25/2022
   Technical assessment for GDC IT Solutions
*/

using System;
using System.IO;

namespace CSVFileParse
{
    class Program
    {
        static void Main(String[] args)
        {
            // Get file name from the user
            Console.WriteLine("**Automatically checks for file extension**");
            Console.WriteLine("Enter file name:");
            var fileName = Console.ReadLine();

            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("\nCurrent directory is {0}", path);

            // Check if file exists
            if (File.Exists(fileName + ".csv"))
            {
                Console.WriteLine("\nFile exists!");
            }
            // Show error message while file does not exist, ask for file name again
            while (!File.Exists(fileName + ".csv"))
            {
                Console.WriteLine("\nERROR: That file does not exist! Reminder: No extension needed.");
                Console.WriteLine("\nEnter file name:");
                fileName = Console.ReadLine();

                if (File.Exists(fileName + ".csv"))
            {
                Console.WriteLine("\nFile exists!");
            }
            }

            // Read the lines from the CSV file
            string[] lines = System.IO.File.ReadAllLines(fileName + ".csv");

            // The lists to hold CSV data
            var firstNames = new List<string>();
            var lastNames = new List<string>();
            var emails = new List<string>();
            var validEmails = new List<string>();
            var invalidEmails = new List<string>();

            // Split the rows into column data
            for (int i = 0; i < lines.Length; i++)
            {
                string[] rows = lines[i].Split(',');

                firstNames.Add(rows[0]);
                lastNames.Add(rows[1]);
                emails.Add(rows[2]);
            }

            // Get valid and invalid emails
            for (int j = 0; j < emails.Count; j++)
            {
                if (emails[j].Contains(".com"))
                {
                    validEmails.Add(emails[j]);
                }
                else
                {
                    invalidEmails.Add(emails[j]);
                }
            }

            // Display valid emails to the user
            Console.WriteLine("\nVALID EMAILS:");
            for (int k = 0; k < validEmails.Count; k++)
            {
                Console.WriteLine(validEmails[k]);
            }

            // Display invalid emails to the user
            Console.WriteLine("\nINVALID EMAILS:");
            for (int h = 0; h < invalidEmails.Count; h++)
            {
                Console.WriteLine(invalidEmails[h]);
            }

            // Get a key press from user to exit program
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
