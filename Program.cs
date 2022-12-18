using System;
using System.IO;

namespace AOC_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("TestFile.txt"))
                {
                    string line;
                    int highestCalorieSum = int.MinValue;
                    int currentCalorieSum = 0;
                    int currentLine = 0;
                    bool convertToInt;
                   

                    // Read and display lines from the file until the end of
                    // the file is reached.

                    while ((line = sr.ReadLine()) != null)
                    {
                        convertToInt = int.TryParse(line, out currentLine); // Convert parsed string into an integer
                        currentCalorieSum = currentCalorieSum + currentLine; // Add parsed integer to current calorie sum
                       
                        if (string.IsNullOrWhiteSpace(line))  // If statement to see if line is blank and if so check against highest number
                        {
                            if (currentCalorieSum > highestCalorieSum)
                            {
                                highestCalorieSum = currentCalorieSum;
                               
                            }
                            currentCalorieSum = 0; //reset currentCalorieSum for next iteration
                        }

                       
                        
                    }
                    Console.WriteLine("The highest Calorie sum is: " + highestCalorieSum);
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
