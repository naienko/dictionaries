using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main()
        {
// create a dictionary with key value pairs to represent words (key) and its definition (value) 
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // add several words and their definition
            wordsAndDefinitions.Add("Cohort 30", "Pretty damn cool cohort");
            wordsAndDefinitions.Add("Awesome", "Cohort 30 learning C#");
			wordsAndDefinitions.Add("Sexy", "Grant Gustin");
			wordsAndDefinitions.Add("Glasses", "Annoying");

            // use square bracket lookup to get the definition of a specific word

			Console.WriteLine($"Sexy is {wordsAndDefinitions["Sexy"]}");

            // loop over dictionary to get the following output: "The definition of [WORD] is [DEFINITION]"
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) {
				Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
            }

        }
    }
}

