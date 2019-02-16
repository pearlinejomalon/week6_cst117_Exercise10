using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //location of file to be read
            string path = "Exercise10.txt";

            //Initialize the stream reader
            StreamReader inputFile = File.OpenText(path);

            //Create list to store strings
            List<string> singleWords = new List<string>();
            List<string> fileText = new List<string>();

            //Create array to separate read line into single words
            string[] tokens;

            //Initialeze counter to add the number of words that end with t or e
            int counter = 0;

            //Read files untile the end of te file
            while (!inputFile.EndOfStream)
            {
                //Add each line in the text file to a list
                fileText.Add(inputFile.ReadLine());
            }

            //Start for each loop to separate the individual words
            foreach(string str in fileText)
            {
                //Remove the individual words from the read line
                tokens = str.Split(null);

                //Add all the individual words to the list
                singleWords.AddRange(tokens);
            }

            //Test each word that ends with t or e
            foreach (string str in singleWords)
            {
                //Set strin to lowercase and test for t or e. If true add counter
                if (str.ToLower().EndsWith("t") || str.ToLower().EndsWith("e"))
                counter++;
            }

            //Send results to console
            Console.WriteLine(String.Format("There are {0} word that end in 't' or 'e' ", counter));

            //Pause console
            Console.WriteLine("Press any key to exit...");

            //Close console after any key is pressed
            Console.ReadLine();
        }
    }
}
