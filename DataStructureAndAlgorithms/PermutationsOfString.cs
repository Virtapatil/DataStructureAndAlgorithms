using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class PermutationGenerator
    {
        // Iterative method to generate all permutations of a string
        /*public static string[] GetPermutationsIterative(string str)
        {
            List<string> permutations = new List<string>();
            permutations.Add(str);

            int length = str.Length;

            while (true)
            {
                int i = length - 2;
                while (i >= 0 && str[i] >= str[i + 1])
                {
                    i--;
                }

                if (i < 0)
                {
                    break;
                }

                int j = length - 1;
                while (str[i] >= str[j])
                {
                    j--;
                }

                Swap(ref str[i], ref str[j]);
                ReverseString(str, i + 1, length - 1);

                permutations.Add(str);
            }

            return permutations.ToArray();
        }

        // Recursive method to generate all permutations of a string
        public static string[] GetPermutationsRecursive(string str)
        {
            List<string> permutations = new List<string>();
            GeneratePermutations(str.ToCharArray(), 0, str.Length - 1, permutations);
            return permutations.ToArray();
        }

        private static void GeneratePermutations(char[] chars, int start, int end, List<string> permutations)
        {
            if (start == end)
            {
                permutations.Add(new string(chars));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref chars[start], ref chars[i]);
                    GeneratePermutations(chars, start + 1, end, permutations);
                    Swap(ref chars[start], ref chars[i]); // Backtracking
                }
            }
        }

        private static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        private static void ReverseString(char[] chars, int start, int end)
        {
            while (start < end)
            {
                Swap(ref chars[start], ref chars[end]);
                start++;
                end--;
            }
        }

        // Function to check if two arrays are equal
        public static bool ArraysAreEqual(string[] arr1, string[] arr2)
        {
            if (arr1.Length != arr2.Length)
            {
                return false;
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }*/
    }
}
