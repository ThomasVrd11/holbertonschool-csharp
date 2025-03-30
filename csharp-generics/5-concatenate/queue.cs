﻿using System;

class Queue<T>
{
    /// <summary>Head of the queue</summary>
    public Node head;

    /// <summary>Tail of the queue</summary>
    public Node tail;

    /// <summary>Number of elements in the queue</summary>
    public int count;

    /// <summary>
    /// Node class
    /// </summary>
    public class Node
    {
        /// <summary>value of the node</summary>
        public T value;

        /// <summary>Next node in the queue</summary>
        public Node next;

        /// <summary>
        /// Constructor for the node
        /// </summary>
        /// <param name="value">value of the node</param>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Returns the type of the queue
    /// </summary>
    /// <returns>type of the queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Adds a value to the end of the queue
    /// </summary>
    /// <param name="value">value to add</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Remove the first node in the queue
    /// </summary>
    /// <returns>value of the removed node</returns>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T removedValue = head.value;
            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            count--;
            return removedValue;
        }
    }

    /// <summary>
    /// Return the value of the first node in the queue
    /// </summary>
    /// <returns>return the value of the first node of the queue</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    /// <summary>
    /// Print the queue starting from the head
    /// </summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }

    /// <summary>
    /// Concatenate the values of the queue if the queue is
    /// of type String or Char
    /// </summary>
    /// <returns>return string or null</returns>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        Type typeOfQueue = CheckType();
        if (typeOfQueue != typeof(string) && typeOfQueue != typeof(char))
        {
            Console.WriteLine("Concatenate is for a queue of Strings or Chars only.");
            return null;
        }

        Node current = head;
        string result = "";
        while (current != null)
        {
            result += current.value;
            if (typeOfQueue == typeof(string) && current.next != null)
                result += " ";

            current = current.next;
        }
        return result;
    }

    /// <summary>
    /// Return the number of elements in the queue
    /// </summary>
    public int Count()
    {
        return count;
    }
}


