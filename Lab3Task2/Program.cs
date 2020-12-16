using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the time in 24-hr format inserting colon after hours and minutes (e.g. hh:mm:ss):");
            string[] temp = Console.ReadLine().Split(':');
            int h = Convert.ToInt32(temp[0]);
            int m = Convert.ToInt32(temp[1]);
            int s = Convert.ToInt32(temp[2]);
            MyTime t = new MyTime(h, m, s);
            Console.WriteLine("");
            Console.WriteLine("Seconds elapsed since midnight (00:00:00):");
            Console.WriteLine(t.TimeSinceMidnight());

            Console.WriteLine("");

            Console.WriteLine("Add one hour:  {0}", t.AddOneHour());
            Console.WriteLine("Add one minute:  {0}", t.AddOneMinute());
            Console.WriteLine("Add one second:  {0}", t.AddOneSecond());

            Console.WriteLine("");

            Console.WriteLine("Enter the number of seconds you want to add:");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine(t.AddSeconds(seconds));


            Console.WriteLine("");

            Console.WriteLine("Enter the number of seconds that have passed since midnight to know the exact time:");
            int SecondFromTheStart = int.Parse(Console.ReadLine());
            Console.WriteLine(t.TimeSinceMidnight(SecondFromTheStart));

            Console.WriteLine("");

            Console.WriteLine("To determine the difference between two points of time enter the first point of time in 24-hr format inserting colon after hours and minutes (e.g. hh:mm:ss):");
            string[] temp1 = Console.ReadLine().Split(':');
            int h1 = Convert.ToInt32(temp1[0]);
            int m1 = Convert.ToInt32(temp1[1]);
            int s1 = Convert.ToInt32(temp1[2]);
            MyTime mt1 = new MyTime(h1, m1, s1);
            Console.WriteLine("");
            Console.WriteLine("Enter the second point of time in 24-hr format inserting colon after hours and minutes (e.g. hh:mm:ss):");
            string[] temp2 = Console.ReadLine().Split(':');
            int h2 = Convert.ToInt32(temp2[0]);
            int m2 = Convert.ToInt32(temp2[1]);
            int s2 = Convert.ToInt32(temp2[2]);
            MyTime mt2 = new MyTime(h2, m2, s2);
            Console.WriteLine("");
            Console.WriteLine("The difference between these two points of time in seconds is:");
            Console.WriteLine(mt1.Difference(mt1, mt2));

            Console.WriteLine("");
            Console.WriteLine("Enter the time in 24-hr format inserting colon after hours and minutes to find out which class it is right now (e.g. hh:mm:ss):");
            string[] temp3 = Console.ReadLine().Split(':');
            int h3 = Convert.ToInt32(temp3[0]);
            int m3 = Convert.ToInt32(temp3[1]);
            int s3 = Convert.ToInt32(temp3[2]);
            Console.WriteLine("");
            MyTime y3 = new MyTime(h3, m3, s3);
            Console.WriteLine(y3.WhatLesson());

            Console.ReadKey();
        }
    }
}
