﻿using LeQuyetTienMidterm2;
using System;
using System.Collections;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select an option:");
        Console.WriteLine("===================================");
        Console.WriteLine("\t1. Insert new student...");
        Console.WriteLine("\t2. Display all the student list...");
        Console.WriteLine("\t3. Calculator average mark...");
        Console.WriteLine("\t4. Search student...");
        Console.WriteLine("\t5. Exit.");
        Console.WriteLine("===================================");
        
        Hashtable students = new Hashtable();
        while (true)
        {
            Console.Write("Option: ");
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Student std = new Student();
                    Console.Write("Input student ID: "); std.StudID=int.Parse(Console.ReadLine());
                    Console.Write("Input student name: "); std.StudName = Console.ReadLine();
                    Console.Write("Input student gender: "); std.StudGender = Console.ReadLine();
                    Console.Write("Input student age: "); std.StudAge = int.Parse(Console.ReadLine());
                    Console.Write("Input student class: "); std.StudClass = Console.ReadLine();
                    Console.WriteLine("Input student mark: ");
                    Console.Write("\tInput mark 1: ");
                    std.MarkList[0]=int.Parse(Console.ReadLine());
                    Console.Write("\tInput mark 2: ");
                    std.MarkList[1] = int.Parse(Console.ReadLine());
                    Console.Write("\tInput mark 3: ");
                    std.MarkList[2] = int.Parse(Console.ReadLine());
                    students.Add(std.StudID, std);
                    break;
                case 2:
                    Console.WriteLine("List student:");
                    foreach (Student st in students.Values)
                    {
                        st.Print();
                    }
                    break;
                case 3:
                    Console.WriteLine("List student:");
                    foreach (Student st in students.Values)
                    {
                        st.CalAvg();
                        st.Print();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Find student: ");
                        Console.WriteLine("- 1. By id");
                        Console.WriteLine("- 2. By name");
                        Console.WriteLine("- 3. By class");
                        Console.Write("Choose option: "); int choice2 = int.Parse(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                Console.Write("Enter ID: ");
                                int findid = int.Parse(Console.ReadLine());
                                bool a = false;
                                foreach(Student st in students.Values)
                                {
                                    if (st.StudID == findid)
                                    {
                                        st.Print();
                                        a = true;
                                    }
                                }
                                if (a == false) Console.WriteLine("Can not find student");
                                break;
                            case 2:
                                Console.Write("Enter name: ");
                                string findname= Console.ReadLine();
                                bool b=false;
                                foreach(Student st in students.Values)
                                {
                                    if(st.StudName == findname)
                                    {
                                        st.Print();
                                        b=true;
                                    }
                                }
                                if (b == false) Console.WriteLine("Can not find student");
                                break;
                            case 3:
                                Console.Write("Enter class: ");
                                string findclass = Console.ReadLine();
                                bool c = false;
                                foreach (Student st in students.Values)
                                {
                                    if (st.StudClass == findclass)
                                    {
                                        st.Print();
                                        c = true;
                                    }
                                }
                                if (c == false) Console.WriteLine("Can not find student");
                                break;
                        }
                        break;
                    }
                case 5: 
                    return;
            }
        }
        
    }
}