using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Task2
{
    class MyTime
    {
        protected int hour, minute, second;

        public MyTime(int h, int m, int s)
        {
            hour = h;
            minute = m;
            second = s;
        }
        public override string ToString()
        {
            return string.Format(hour + ":" + minute.ToString("00") + ":" + second.ToString("00"));
        }
        public int TimeSinceMidnight()
        {
            int sec = (((second + minute * 60 + hour * 3600) % 86400) + 86400) % 86400;
            return sec;
        }
        public MyTime TimeSinceMidnight(int t)
        {
            t = ((t % 86400) + 86400) % 86400;
            int h = t / 3600;
            int m = (t / 60) % 60;
            int s = t % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneMinute()
        {
            int temp = (((second + (minute + 1) * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneHour()
        {
            int temp = (((second + minute * 60 + (hour + 1) * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddOneSecond()
        {
            int temp = (((second + 1 + minute * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public MyTime AddSeconds(int s)
        {
            int temp = (((second + s + minute * 60 + hour * 3600) % 86400) + 86400) % 86400;
            hour = temp / 3600;
            minute = (temp / 60) % 60;
            second = temp % 60;
            return new MyTime(hour, minute, second);
        }
        public int Difference(MyTime mt1, MyTime mt2)
        {
            return (mt1.TimeSinceMidnight() - mt2.TimeSinceMidnight());
        }
        public string WhatLesson()
        {
            int seconds = TimeSinceMidnight();
            if (seconds > 0 && seconds < 28800) return "Classes haven't started yet";
            else if (seconds >= 28800 && seconds < 33600) return "1st class";
            else if (seconds >= 33600 && seconds < 34800) return "Recess after 1st class";
            else if (seconds >= 34800 && seconds < 39600) return "2nd class";
            else if (seconds >= 39600 && seconds < 40800) return "Recess after 2nd class";
            else if (seconds >= 40800 && seconds < 45600) return "3rd class";
            else if (seconds >= 45600 && seconds < 46800) return "Recess after 3rd class";
            else if (seconds >= 46800 && seconds < 51600) return "4th class";
            else if (seconds >= 51600 && seconds < 52800) return "Recess after 4th class";
            else if (seconds >= 52800 && seconds < 57600) return "5th class";
            else if (seconds >= 57600 && seconds < 58200) return "Recess after 5th class";
            else if (seconds >= 58200 && seconds < 63000) return "6th class";
            else if (seconds >= 63000 && seconds < 86400) return "Classes have ended";
            else return "Error: you have entered the wrong value";
        }

    }
}
