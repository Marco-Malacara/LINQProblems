using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1");
            IEnumerable<string> listOfWords = new SubstringTH().GetTH(new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" });
            foreach (string word in listOfWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Problem 2");
            List<string> names = new List<string>() { "Mike", "Dan", "Scott", "Nick", "Mike" };
            IEnumerable<string> list = new Deduplicator().RemoveDuplicates(names);
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Problem 3");
            List<string> classGrades = new List<string>() {"80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            double gradeAverage = new ClassAverage().GetClassAverage(classGrades);
            
            
            Console.WriteLine(gradeAverage);

            Console.WriteLine("\n");

            Console.WriteLine("Problem 4");
            Terrill terrill = new Terrill();
            string result = terrill.GetFrequency("terrill");
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
