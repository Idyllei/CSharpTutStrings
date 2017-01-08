using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string randStr = "This is a string";
            Console.WriteLine("String Length : {0}", randStr.Length);
            Console.WriteLine("String Contains is : {0}", randStr.Contains("is"));
            Console.WriteLine("Index of is : {0}", randStr.IndexOf("is"));
            Console.WriteLine("Remove String : {0}", randStr.Remove(0, 6)); // Starting at index 0, remove 6 characters.
            Console.WriteLine("Insert String : {0}", randStr.Insert(10, "short " )); // At index 10, insert "short ".
            Console.WriteLine("Replace String : {0}", randStr.Replace("string", "sentence"));
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("A = a : {0}", String.Equals("A", "a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Pad Left : {0}", randStr.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}", randStr.PadRight(20, '.'));
            Console.WriteLine("Trim : {0}", randStr.Trim());
            Console.WriteLine("Uppercase : {0}", randStr.ToUpper());
            Console.WriteLine("Lowercase : {0}", randStr.ToLower());

            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "field");
            Console.WriteLine(newString);

            Console.Write(@"Exactly what I typed ' \");

            Console.ReadLine();
        }
    }
}
