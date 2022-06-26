using System;

namespace HashTables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating  Hash Tables");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(19);

            //Adding Element into Hash Table
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            // Getting 10th index value from the Hash table
            string hash1 = hash.Get("10");
            Console.WriteLine("10th Index Value is :" + hash1);

            // Getting 8th index value from the Hash table
            string hash2 = hash.Get("8");
            Console.WriteLine("8th Index Value is :" + hash2);

            Console.WriteLine("...............................");

            Console.WriteLine("Removing 10th index value");
            Console.WriteLine("\n");

            // Remove the element from the Hash Tables
            hash.Remove("10");

            string hash3 = hash.Get("10");
            Console.WriteLine("10th index after removal:  " + hash3);

        }
    }
}
