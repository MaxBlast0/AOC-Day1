using System;
using System.Collections.Generic;
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
                    List<int> calorieSumList = new List<int>();


                    // Read and display lines from the file until the end of
                    // the file is reached.

                    while ((line = sr.ReadLine()) != null)
                    {
                        convertToInt = int.TryParse(line, out currentLine); 
                        currentCalorieSum = currentCalorieSum + currentLine; 
                       
                        if (string.IsNullOrWhiteSpace(line))  
                        {
                            if (currentCalorieSum > highestCalorieSum)
                            {
                                highestCalorieSum = currentCalorieSum;
                               
                            }
                            calorieSumList.Add(currentCalorieSum);
                            currentCalorieSum = 0; 
                        }       
                    }
                    calorieSumList.Sort();
                    calorieSumList.Reverse();
                   Console.WriteLine("The highest calorie sum is: " + highestCalorieSum);
                   int top3Calories = (calorieSumList[0] + calorieSumList[1] + calorieSumList[2]);
                    Console.WriteLine("The sum of calories for the top 3 elves is: " + top3Calories);
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
