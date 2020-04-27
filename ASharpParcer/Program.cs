using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    class Program
    {
        public List<string> Lines = new List<string>();

        public List<long> Vars = new List<long>();

        public List<JumpPoint> JumpPlaces = new List<JumpPoint>();

        public struct JumpPoint
        {
            public int lineId;
            public string pointName;
        }

        public void ReadExecLine(int i)
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "d:/Git/test.txt";
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }
    }
}
