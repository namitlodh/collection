using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Creating a HashSet
        HashSet<int> myHashSet = new HashSet<int>();

        // Adding elements to the HashSet
        myHashSet.Add(1);
        myHashSet.Add(2);
        myHashSet.Add(3);

        // Displaying the elements in the HashSet
        DisplayHashSet(myHashSet);

        // Checking if an element is present
        int searchElement = 2;
        Console.WriteLine($"Is {searchElement} present in the HashSet? {myHashSet.Contains(searchElement)}");

        // Removing an element
        myHashSet.Remove(2);

        // Displaying the updated HashSet
        Console.WriteLine("\nHashSet after removing element 2:");
        DisplayHashSet(myHashSet);

        // Clearing the HashSet
        myHashSet.Clear();

        // Checking if the HashSet is empty
        Console.WriteLine("\nIs the HashSet empty? " + (myHashSet.Count == 0));
    }

    static void DisplayHashSet(HashSet<int> hashSet)
    {
        Console.WriteLine("Elements in the HashSet:");
        foreach (var item in hashSet)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
