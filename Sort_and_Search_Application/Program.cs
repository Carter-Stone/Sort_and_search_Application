using System.Runtime.CompilerServices;

namespace ReadTxtFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the directory containing the text files: ");
            string directoryPath = Console.ReadLine();

            List<int[]> arrays = new List<int[]>();
            foreach (string filePath in Directory.GetFiles(directoryPath, "*.txt"))
            {
                string[] lines =  File.ReadAllLines(filePath);
                int[] array = Array.ConvertAll(lines, int.Parse);
                arrays.Add(array);
            }