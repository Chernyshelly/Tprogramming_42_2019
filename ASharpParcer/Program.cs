using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    public class Program
    {
        public List<string> Lines { get; set; } = new List<string>();

        public List<long> Vars { get; set; } = new List<long>();

        public List<JumpPoint> JumpPlaces { get; set; } = new List<JumpPoint>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "d:/Git/test.txt";
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }

        public void ReadExecLine(int i)
        {
        }

        public struct JumpPoint
        {
            public int LineId;
            public string PointName;
        }
    }
}
