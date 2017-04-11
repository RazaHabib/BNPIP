using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations
{
    public class Program
    {
        private static bool addMoreInputStrings = true;
        private static List<string> inputStrings = new List<string>();

        static void Main(string[] args)
        {
            while (addMoreInputStrings) {
                Console.WriteLine("Pleae enter a string");
                getInputString();
            }
            List<string> matchedStrings = filterListData(inputStrings);
            if (matchedStrings.Count == 0) {
                Console.WriteLine("No string matched");
            }
            else {
                Console.WriteLine("Following items Matched");
                foreach (var item in matchedStrings)
                {
                    Console.WriteLine(item + "\n");
                }
            }
            Console.ReadLine();
        }

        private static void getInputString()
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "n") {               
                addMoreInputStrings = false;
            }
            else {
                if (input.Length <= 6) {
                    inputStrings.Add(input);
                }
                else {
                    Console.WriteLine("Please enter a string of Max 6 characters. Enter [N] to start Filtering");
                }
                // recursive call to get further input strings
                getInputString();
            }
        }

        public static List<string> filterListData(List<string> input)
        {
            List<string> matchedStrings = new List<string>();
            int match = 0;

            if (input.Count > 1) {
                //ToDO: Use LINQ for faster operation
                foreach (var str1 in input) {
                    foreach (var str2 in input) {
                        if (str1 != str2) {
                            if (str1.Contains(str2)) {
                                match++;
                                if (match == 2) {
                                    match = 0;
                                    if (!matchedStrings.Contains(str1)) {
                                        matchedStrings.Add(str1);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return matchedStrings;
        }
    }
}
