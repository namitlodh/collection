using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<int> mylist = new List<int> { 1, 2, 3, 4, 5 };
        mylist.Add(6);
        mylist.Insert(2, 10);
        Console.WriteLine("Element at index 3: " + mylist[3]);
        Console.Write("Sliced elements from index 1 to 4: ");
        foreach (int element in mylist.GetRange(1, 4))
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
        mylist.Remove(3);
        int poppedElement = mylist[1];
        mylist.RemoveAt(1);
        mylist.Clear();
        mylist.Add(20);
        mylist[0] = 20;

        // Concatenate lists
        List<int> anotherList = new List<int> { 7, 8, 9 };
        List<int> combinedList = new List<int>(mylist);
        combinedList.AddRange(anotherList);

        // Length of the list
        int length = combinedList.Count;

        // Search for an element
        bool elementPresent = combinedList.Contains(20);
        int indexOf8 = combinedList.IndexOf(8);

        // Count occurrences
        int occurrencesOf5 = combinedList.Count(x => x == 5);


        combinedList.Sort();
        combinedList.Reverse();

        List<int> copiedList = new List<int>(combinedList);

        Console.Write("Iterating over elements: ");
        foreach (int element in copiedList)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();

        // Print the final results
        Console.WriteLine("Combined List: " + string.Join(", ", combinedList));
        Console.WriteLine("Length of the Combined List: " + length);
        Console.WriteLine("Is 20 present in the list? " + elementPresent);
        Console.WriteLine("Index of 8 in the list: " + indexOf8);
        Console.WriteLine("Occurrences of 5 in the list: " + occurrencesOf5);
        Console.ReadLine();
    }
}