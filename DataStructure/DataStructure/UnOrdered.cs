using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DS_Algorithm
{
    class UnOrderedList
    {
        public void UnOrdered()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            string NumfilePath = File.ReadAllText(@"E:\DataALgo\AlgoDataStructure\DataStructure\DataStructure\Utility\WordText.cs");

            string[] words = NumfilePath.Split(",");

            Console.WriteLine("Length of the text is {0}", words.Length); //detecting & writing length of text

            foreach (string result in words)

            {
                linkedList.AddLast(result);
            }
            Display(linkedList);//displaying data

            Console.WriteLine("Type Word For Searching");  ///taking word for search

            string searchdata = Console.ReadLine();

            if (linkedList.Contains(searchdata))
            {
                linkedList.Remove(searchdata);//if there is search data then remove it from list

                Console.WriteLine("{0}  Removed from the File", searchdata);// and write removed the search data
            }
            else
            {
                linkedList.AddLast(searchdata); //if there is no search data then add it into list

                Console.WriteLine("{0} is added to the file", searchdata); //write else condition 
            }
            File.WriteAllText(@"D:\DS AlgorithmProgram\DS-Algorithm-And-Programming\DS Algorithm\DS Algorithm\Utility\Word.txt", NumfilePath);
            Display(linkedList);
        }
        private void Display(LinkedList<string> linkedList)
        {
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
