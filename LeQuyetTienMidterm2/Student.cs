using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeQuyetTienMidterm2
{
    internal class Student: IStudent
    {
        public int StudID { get; set; }
        public string StudName { get; set; }
        public string StudGender { get; set; }
        public int StudAge { get; set; }
        public string StudClass { get; set; }
        public float StudAvgMark { get; private set; }
        public void Print()
        {
            Console.WriteLine("Student's information: ");
            Console.WriteLine("ID: " + StudID);
            Console.WriteLine("Name: " + StudName);
            Console.WriteLine("Gender: " + StudGender);
            Console.WriteLine("Age: " + StudAge);
            Console.WriteLine("Class: " + StudClass);
            Console.WriteLine("Avg Mark: " + StudAvgMark);
        }
        public int[] MarkList = new int[3];
        public int this[int i]
        {
            get { return MarkList[i]; }
            set { MarkList[i] = value; }
        }
        public float CalAvg()
        {
            foreach(int mark in MarkList)
            {
                StudAvgMark += mark;
            }
            StudAvgMark = StudAvgMark / 3;
            return StudAvgMark;
        }
        public override string ToString()
        {
            return "\nName: " + StudName +
            "\nGender: " + StudGender +
            "\nAge: " + StudAge +
            "\nClass: " + StudClass;
        }
    }
}
