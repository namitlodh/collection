using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Creating a Queue
        Queue myQueue = new Queue();

        // Enqueue elements
        myQueue.Enqueue("Element 1");
        myQueue.Enqueue("Element 2");
        myQueue.Enqueue("Element 3");

        // Displaying the elements in the Queue
        DisplayQueue(myQueue);

        // Peek at the front element
        Console.WriteLine("Front element: " + myQueue.Peek());

        // Dequeue elements
        while (myQueue.Count > 0)
        {
            Console.WriteLine("Dequeue: " + myQueue.Dequeue());
        }

        // Check if the Queue is empty
        Console.WriteLine("Is the Queue empty? " + (myQueue.Count == 0));
    }

    static void DisplayQueue(Queue queue)
    {
        Console.WriteLine("Elements in the Queue:");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.ReadLine();
    }
}
