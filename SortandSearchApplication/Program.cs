using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SortandSearchApplication
    {
        static void Main(string[] args)
        {
            //prompt the user to input the text file directory
            Console.WriteLine("Enter the directory containing the text files: ");
            string directoryPath = Console.ReadLine();

            //read each file and create individual arrays
            List<int[]> arrays = new List<int[]>();
            foreach (string filePath in Directory.GetFiles(directoryPath, ".txt"))
            {
                string[] lines = File.ReadAllLines(filePath);
                int[] array = Array.ConvertAll(lines, int.Parse); //convert strings into 32bit integers
                arrays.Add(array);
            }
            //if (arrays.Count < 1){
            //    Main(args);
            //}
            
            //sort into ascending order
            int N = 0;
            foreach (int[] array in arrays)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            N = array[i];
                            array[i] = array[j];
                            array[j] = N;
                        }
                    }

                }
            }


            // prints the 10th integer of each array
            Console.WriteLine("Every 10th value in each array: ");
            foreach (int[] array in arrays)
            {
                for (int i = 0; i < array.Length; i += 10)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }

            //prompt the user for a value to find
            Console.WriteLine("Enter a Value to Search for: ");
            int value = int.Parse(Console.ReadLine());

            //find the value in the array using binary search
            List<int> locations = new List<int>();
            foreach (int[] array in arrays)
            {
                int left = 0;
                int right = array.Length - 1;

                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (array[mid] == value)
                    {
                        locations.Add(mid);
                    }
                    else if (array[mid] > value)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }

            }
            Console.WriteLine("Locations of the value:");
            Console.WriteLine(string.Join(",", locations));
        }
    }
}


