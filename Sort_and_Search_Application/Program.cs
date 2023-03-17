using System.Runtime.CompilerServices;

namespace ReadTxtFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user to input the text file directory
            Console.WriteLine("Enter the directory containing the text files: ");
            string directoryPath = Console.ReadLine();

            //read each file and create individual arrays
            List<int[]> arrays = new List<int[]>();
            foreach (string filePath in Directory.GetFiles(directoryPath, "*.txt"))
            {
                string[] lines = File.ReadAllLines(filePath);
                int[] array = Array.ConvertAll(lines, int.Parse); //convert strings into 32bit integers
                arrays.Add(array);
            }
            //sort into ascending order
            int N = 0;
            foreach (int[] array in arrays)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j <= array.Length; j++)
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

            //find the value in the array
            List<int> locations = new List<int>();
            for (int i = 0; i < )

        }
    }
}
            