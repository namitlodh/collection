using System;
using System.Collections.Generic;
class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    // Add an element to the end of the linked list
    public void AddToEnd(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Add an element to the beginning of the linked list
    public void AddToBeginning(int data)
    {
        Node newNode = new Node(data);
        newNode.Next = head;
        head = newNode;
    }

    // Remove an element from the linked list
    public void Remove(int data)
    {
        if (head == null)
        {
            Console.WriteLine("The linked list is empty.");
            return;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null && current.Next.Data != data)
        {
            current = current.Next;
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
        else
        {
            Console.WriteLine($"Element {data} not found in the linked list.");
        }
    }

    // Search for an element in the linked list
    public bool Contains(int data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    // Display the elements in the linked list
    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main()
    {
        LinkedList myLinkedList = new LinkedList();

        // Add elements to the end of the linked list
        myLinkedList.AddToEnd(1);
        myLinkedList.AddToEnd(2);
        myLinkedList.AddToEnd(3);

        // Display the linked list
        Console.WriteLine("Linked List:");
        myLinkedList.Display();

        // Add an element to the beginning of the linked list
        myLinkedList.AddToBeginning(0);

        // Display the updated linked list
        Console.WriteLine("\nLinked List after adding to the beginning:");
        myLinkedList.Display();

        // Remove an element from the linked list
        myLinkedList.Remove(2);

        // Display the updated linked list
        Console.WriteLine("\nLinked List after removing element 2:");
        myLinkedList.Display();

        // Search for an element in the linked list
        int searchData = 3;
        Console.WriteLine($"\nIs {searchData} present in the linked list? {myLinkedList.Contains(searchData)}");

        int search1 = 4;
        Console.WriteLine($"\nIs {search1} present in the linked list? {myLinkedList.Contains(search1)}");
        Console.ReadLine();
    }
}
