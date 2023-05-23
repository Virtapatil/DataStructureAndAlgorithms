using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class InsertionSort
    {
        public static void Main(string[] args)
        {
            // Read the list of words
            Console.Write("Enter the words (comma-separated): ");
            string input = Console.ReadLine();
            string[] words = input.Split(',');

            // Perform insertion sort
            InsertionSort(words);

            // Print the sorted list
            Console.WriteLine("Sorted List:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
