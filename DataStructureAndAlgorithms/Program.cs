namespace DataStructureAndAlgorithms
{
    internal class Program
    {
        /*public static void Main(string[] args)
        {
            string input = "abc";

            // Using iterative method
            string[] iterativePermutations = PermutationGenerator.GetPermutationsIterative(input);

            // Using recursive method
            string[] recursivePermutations = PermutationGenerator.GetPermutationsRecursive(input);

            // Check if the arrays returned by two string functions are equal
            bool areEqual = PermutationGenerator.ArraysAreEqual(iterativePermutations, recursivePermutations);

            Console.WriteLine("Iterative Permutations:");
            PrintArray(iterativePermutations);

            Console.WriteLine("Recursive Permutations:");
            PrintArray(recursivePermutations);

            Console.WriteLine("Are the arrays equal? " + areEqual);
        }

        private static void PrintArray(string[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }*/
        /*public static void Main(string[] args)
        {
            // Read the list of words from a file
            string[] wordList = ReadWordListFromFile("wordlist.txt");

            // Sort the word list
            Array.Sort(wordList);

            // Prompt the user to enter a word to search
            Console.Write("Enter a word to search: ");
            string searchWord = Console.ReadLine();

            // Perform binary search
            bool found = BinarySearch(wordList, searchWord);

            // Print the result
            if (found)
            {
                Console.WriteLine("The word '{0}' is found in the list.", searchWord);
            }
            else
            {
                Console.WriteLine("The word '{0}' is not found in the list.", searchWord);
            }
        }

        private static string[] ReadWordListFromFile(string fileName)
        {
            string[] wordList;
            try
            {
                wordList = File.ReadAllText(fileName).Split(',');
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File '{0}' not found.", fileName);
                wordList = new string[0];
            }
            return wordList;
        }

        private static bool BinarySearch(string[] arr, string searchWord)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int result = String.Compare(arr[mid], searchWord, StringComparison.Ordinal);

                if (result == 0)
                {
                    return true; // Found
                }
                else if (result < 0)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }

            return false; // Not found
        }*/
        private static void InsertionSortWords(string[] words)
        {
            int length = words.Length;

            for (int i = 1; i < length; i++)
            {
                string key = words[i];
                int j = i - 1;

                while (j >= 0 && string.Compare(words[j], key, StringComparison.OrdinalIgnoreCase) > 0)
                {
                    words[j + 1] = words[j];
                    j--;
                }

                words[j + 1] = key;
            }
        }
    }
}