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
        }
    }
}
            