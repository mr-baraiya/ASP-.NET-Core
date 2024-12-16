using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program-1
            //1. Create an ArrayList for StudentName and perform following operations:
            //a. Add() - To Add new student in list
            //b. Remove() - To Remove Student with specified index
            //c. RemoveRange() - To Remove student with specified range.
            //d. Clear() - To clear all the student from the list

            //ArrayList StudentName = new ArrayList();
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Enter 0:TerminateTheCode 1:add() , 2:Remove() , 3:RemoveRange() , 4.clear");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    switch (i)
            //    {   
            //        case 0:
            //            break;
            //        case 1:
            //            Console.WriteLine("Enetr the value To be insert : ");
            //            StudentName.Add(Console.ReadLine());

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            Console.WriteLine("Enetr the value To be remove : ");
            //            StudentName.Remove(Console.ReadLine());

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enetr the Start Index : ");
            //            int start = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enetr the count Of Elemant To Remove : ");
            //            int count = Convert.ToInt32(Console.ReadLine());
            //            StudentName.RemoveRange(start, count);

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine("Are You Sure !\n Please Enter 1.");
            //            int flag = Convert.ToInt32(Console.ReadLine());
            //            if(flag == 1)
            //            {
            //                StudentName.Clear();
            //            }
            //            Console.WriteLine("Your List was Cleared.");
            //            break ;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            Console.WriteLine("Re Enter the value : ");
            //            break;
            //    }
            //} while (i != 0);
            //Console.WriteLine("Program Was Complated!");

            //Program-2
            //2.Create a List for StudentName and perform following operations:
            //a.Add() - To Add new student in list
            //b.Remove() - To Remove Student with specified index
            //c.RemoveRange() - To Remove student with specified range.
            //d.Clear() - To clear all the student from the list

            //List<String> StudentName = new List<String>();
            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Enter 0:TerminateTheCode 1:add() , 2:Remove() , 3:RemoveRange() , 4.clear");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            Console.WriteLine("Enetr the value To be insert : ");
            //            StudentName.Add(Console.ReadLine());

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            Console.WriteLine("Enetr the value To be remove : ");
            //            StudentName.Remove(Console.ReadLine());

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enetr the Start Index : ");
            //            int start = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("Enetr the count Of Elemant To Remove : ");
            //            int count = Convert.ToInt32(Console.ReadLine());
            //            StudentName.RemoveRange(start, count);

            //            Console.WriteLine("\n Your List is : ");
            //            foreach (Object student in StudentName)
            //            {
            //                Console.WriteLine(student.ToString());
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine("Are You Sure !\n Please Enter 1.");
            //            int flag = Convert.ToInt32(Console.ReadLine());
            //            if (flag == 1)
            //            {
            //                StudentName.Clear();
            //            }
            //            Console.WriteLine("Your List was Cleared.");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            Console.WriteLine("Re Enter the value : ");
            //            break;
            //    }
            //} while (i != 0);
            //Console.WriteLine("Program Was Complated!");

            //Program-3
            //3.Create a Stack which takes integer values and perform following operations:
            //a.Push() - To Add new item in stack
            //b.Pop() - To Remove item from the stack
            //c.Peek() – To Return the top item from the stack.
            //d.Contains() - To Checks whether an item exists in the stack or not.
            //e.Clear() - To clear items from stack

            //Stack<int> stack = new Stack<int>();
            //int i = 0 , n = 0;
            //bool flag = false;
            //do
            //{
            //    Console.WriteLine("Enter 0:TerminateTheCode 1:Push() , 2:Pop() , 3:Peek() , 4.Contains() , 5.clear()");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            Console.WriteLine("Enetr the value To be Push : ");
            //            stack.Push(Convert.ToInt32(Console.ReadLine()));
            //            Console.WriteLine("\n Your Stack is : ");
            //            foreach (var item in stack)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            n = stack.Pop();
            //            Console.WriteLine(" Pop() = "+n);
            //            Console.WriteLine("\n Your Stack is : ");
            //            foreach (var item in stack)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            n = stack.Peek();
            //            Console.WriteLine(" Peek() = " + n);
            //            Console.WriteLine("\n Your Stack is : ");
            //            foreach (var item in stack)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine("Enter the Number : ");
            //            flag = stack.Contains(Convert.ToInt32(Console.ReadLine()));
            //            if (flag)
            //            {
            //                Console.WriteLine("Stack was Contains.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Stack was Not Contains.");
            //            }
            //            Console.WriteLine("\n Your Stack is : ");
            //            foreach (var item in stack)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 5:
            //            Console.WriteLine("Are You Sure !\n Please Enter 1.");
            //            n = Convert.ToInt32(Console.ReadLine());
            //            if (n == 1)
            //            {
            //                stack.Clear();
            //            }
            //            Console.WriteLine("Your Stack was Cleared.");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            Console.WriteLine("Re Enter the value : ");
            //            break;
            //    }
            //} while (i != 0);
            //Console.WriteLine("Program Was Complated!");

            //Program-4
            //4.Create a Queue which takes integer values and perform following operations: 
            //a.Enqueue() - Adds an item into the queue.
            //b.Dequeue() - Returns an item from the beginning of the queue and
            // removes it from the queue.
            //c.Peek() - Returns an first item from the queue without removing it.
            //d.Contains() - Checks whether an item is in the queue or not
            //e.Clear() - Removes all the items from the queue
            //Queue<int> q = new Queue<int>();
            //int i = 0, n = 0;
            //bool flag = false;
            //do
            //{
            //    Console.WriteLine("Enter 0:TerminateTheCode 1:Enqueue() , 2:Dequeue() , 3:Peek() , 4.Contains() , 5.clear()");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            Console.WriteLine("Enetr the value To be Enqueue : ");
            //            q.Enqueue(Convert.ToInt32(Console.ReadLine()));
            //            Console.WriteLine("\n Your Queue is : ");
            //            foreach (var item in q)
            //            {
            //                Console.Write(item+" ");
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            n = q.Dequeue();
            //            Console.WriteLine(" Dequeue() = " + n);
            //            Console.WriteLine("\n Your Queue is : ");
            //            foreach (var item in q)
            //            {
            //                Console.Write(item + " ");
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            n = q.Peek();
            //            Console.WriteLine(" Peek() = " + n);
            //            Console.WriteLine("\n Your Queue is : ");
            //            foreach (var item in q)
            //            {
            //                Console.Write(item + " ");
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine("Enter the Number : ");
            //            flag = q.Contains(Convert.ToInt32(Console.ReadLine()));
            //            if (flag)
            //            {
            //                Console.WriteLine("Queue was Contains.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Queue was Not Contains.");
            //            }
            //            Console.WriteLine("\n Your Queue is : ");
            //            foreach (var item in q)
            //            {
            //                Console.Write(item + " ");
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 5:
            //            Console.WriteLine("Are You Sure !\n Please Enter 1.");
            //            n = Convert.ToInt32(Console.ReadLine());
            //            if (n == 1)
            //            {
            //                q.Clear();
            //            }
            //            Console.WriteLine("Your Queue was Cleared.");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            Console.WriteLine("Re Enter the value : ");
            //            break;
            //    }
            //} while (i != 0);
            //Console.WriteLine("Program Was Complated!");

            //Program-5
            //5.Create a Dictionary collection class object and preform following operations:
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key.
            //c.ContainsKey: Checks if a key exists in the hashtable.
            //d.ContainsValue: Checks if a value exists in the hashtable.
            //e.Clear: Removes all key-value pairs.

            //Dictionary<string,string> dic = new Dictionary<string,string>();
            //int i = 0, n = 0;
            //bool flag = false;
            //string key,value;
            //do
            //{
            //    Console.WriteLine("Enter 0:TerminateTheCode 1:Add() , 2:Remove() , 3:ContainKey() , 4.ContainValue() , 5.clear()");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    switch (i)
            //    {
            //        case 0:
            //            break;
            //        case 1:
            //            Console.WriteLine("Enetr the key : ");
            //            key = Console.ReadLine();
            //            Console.WriteLine("Enetr the Value : ");
            //            value = Console.ReadLine();
            //            dic.Add(key,value);
            //            Console.WriteLine("\n Your Dictionary is : ");
            //            foreach (var item in dic)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 2:
            //            Console.WriteLine("Enetr the key : ");
            //            key = Console.ReadLine();
            //            if (dic.Remove(key))
            //            {
            //                Console.WriteLine(key + "Successfully Removed.");
            //            }
            //            else
            //            {
            //                Console.WriteLine(key + "Not Found.");
            //            }
            //            Console.WriteLine("\n Your Dictionary is : ");
            //            foreach (var item in dic)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 3:
            //            Console.WriteLine("Enetr the key : ");
            //            key = Console.ReadLine();
            //            if (dic.ContainsKey(key))
            //            {
            //                Console.WriteLine($"{key} is Contains in Dictionary.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{key} is Not Contains in Dictionary.");
            //            }
            //            Console.WriteLine("\n Your Dictionary is : ");
            //            foreach (var item in dic)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 4:
            //            Console.WriteLine("Enetr the Value : ");
            //            value = Console.ReadLine();
            //            if (dic.ContainsValue(value))
            //            {
            //                Console.WriteLine($"{value} is Contains in Dictionary.");
            //            }
            //            else
            //            {
            //                Console.WriteLine($"{value} is Not Contains in Dictionary.");
            //            }
            //            Console.WriteLine("\n Your Dictionary is : ");
            //            foreach (var item in dic)
            //            {
            //                Console.WriteLine(item);
            //            }
            //            Console.WriteLine();
            //            break;
            //        case 5:
            //            Console.WriteLine("Are You Sure !\n Please Enter 1.");
            //            n = Convert.ToInt32(Console.ReadLine());
            //            if (n == 1)
            //            {
            //                dic.Clear();
            //            }
            //            Console.WriteLine("Your Dictionary was Cleared.");
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input!");
            //            Console.WriteLine("Re Enter the value : ");
            //            break;
            //    }
            //} while (i != 0);
            //Console.WriteLine("Program Was Complated!");

            //Program-6
            //6.Create a Hashtable collection class object and preform following operations:
            //a.Add: Adds a key-value pair.
            //b.Remove: Removes a key-value pair by key.
            //c.ContainsKey: Checks if a key exists in the hashtable.
            //d.ContainsValue: Checks if a value exists in the hashtable.
            //e.Clear: Removes all key-value pairs.

            Hashtable ht = new Hashtable();
            int i = 0, n = 0;
            bool flag = false;
            string key, value;
            do
            {
                Console.WriteLine("Enter 0:TerminateTheCode 1:Add() , 2:Remove() , 3:ContainKey() , 4.ContainValue() , 5.clear()");
                i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Enetr the key : ");
                        key = Console.ReadLine();
                        Console.WriteLine("Enetr the Value : ");
                        value = Console.ReadLine();
                        ht.Add(key, value);
                        Console.WriteLine("\n Your HashTable is : ");
                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine(entry.Key+" : "+entry.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enetr the key : ");
                        key = Console.ReadLine();
                        ht.Remove(key);
                        Console.WriteLine("\n Your HashTable is : ");
                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine(entry.Key + " : " + entry.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enetr the key : ");
                        key = Console.ReadLine();
                        if (ht.ContainsKey(key))
                        {
                            Console.WriteLine($"{key} is Contains in HashTable.");
                        }
                        else
                        {
                            Console.WriteLine($"{key} is Not Contains in HashTable.");
                        }
                        Console.WriteLine("\n Your HashTable is : ");
                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine(entry.Key + " : " + entry.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Enetr the Value : ");
                        value = Console.ReadLine();
                        if (ht.ContainsValue(value))
                        {
                            Console.WriteLine($"{value} is Contains in HashTable.");
                        }
                        else
                        {
                            Console.WriteLine($"{value} is Not Contains in HashTable.");
                        }
                        Console.WriteLine("\n Your HashTable is : ");
                        foreach (DictionaryEntry entry in ht)
                        {
                            Console.WriteLine(entry.Key + " : " + entry.Value);
                        }
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Are You Sure !\n Please Enter 1.");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n == 1)
                        {
                            ht.Clear();
                        }
                        Console.WriteLine("Your HashTable was Cleared.");
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        Console.WriteLine("Re Enter the value : ");
                        break;
                }
            } while (i != 0);
            Console.WriteLine("Program Was Complated!");
        }
    }
}
