using System;
using System.Collections.Generic;

namespace CSharpGenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization
            var list = new List<int> { 1, 2 };

            //Initialization
            //var list = new List<int>(10);
            var list = new List<int> { 1, 2 };

            //Add
            list.Add(3);
            list.Add(4);
            list.Add(5);
            //list.Add("abcd"); //not allowed

            //AddRange
            var list2 = new List<int> { 6, 7, 8 };
            list.AddRange(list2);

            //Remove
            //list.Remove(3);

            //RemoveAt
            list.RemoveAt(0);

            //clear

            list.Clear();

            //Contains

            Console.WriteLine(list.Contains(10));

            //Reverse
            var list2 = new List<int> { 10, 20, 30 };
            list.InsertRange(1, list2);


            list.Reverse(2, 3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("done...");
            Console.ReadLine();
        }
    }
}
