using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure
{
    internal class Orderedlist
    {
        public void Operation()
        {
            string data = File.ReadAllText(@"E:\RFP\DataStructure\Datastructure\Datastructure\Utility\orderedlistdata.txt");
            Console.WriteLine("-----------------------Data from the file..---------------------------");
            Console.WriteLine(data);
            string[] words = data.Split(' ');
            int[] wordsInts = Array.ConvertAll(words, s => int.Parse(s));
            Array.Sort(wordsInts);
            LinkedList<int> linkedlist = new LinkedList<int>();
            foreach (int item in wordsInts)
            {
                linkedlist.AddLast(item);
            }
            Console.WriteLine("data into array...");
            Display(linkedlist);
            Console.WriteLine("Enter the string you want to search");
            int input = Convert.ToInt32(Console.ReadLine());
            if (linkedlist.Contains(input))
            {
                linkedlist.Remove(input);
                Console.WriteLine($"{input} removed from the list");
            }
            else
            {
                linkedlist.AddLast(input);
                Console.WriteLine($"{input} added to the list");
            }
            Console.WriteLine("-----------Data from the file after changes-----------------");
            Display(linkedlist);
        }
        private void Display(LinkedList<int> linkedlist)
        {
            foreach (var item in linkedlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}