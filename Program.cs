using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Creating a Stack
        Stack myStack = new Stack();

        // Push elements onto the Stack
        myStack.Push("Element 1");
        myStack.Push("Element 2");
        myStack.Push("Element 3");

        // Displaying the elements in the Stack
        DisplayStack(myStack);

        // Peek at the top element
        Console.WriteLine("Top element: " + myStack.Peek());

        // Pop elements
        while (myStack.Count > 0)
        {
            Console.WriteLine("Pop: " + myStack.Pop());
        }

        // Check if the Stack is empty
        Console.WriteLine("Is the Stack empty? " + (myStack.Count == 0));
    }

    static void DisplayStack(Stack stack)
    {
        Console.WriteLine("Elements in the Stack:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
