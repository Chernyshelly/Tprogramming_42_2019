using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    public class Program
    {
        public static List<string> Lines { get; set; } = new List<string>();

        public static List<VarSaved> Vars { get; set; } = new List<VarSaved>();

        public static List<JumpPoint> JumpPlaces { get; set; } = new List<JumpPoint>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "d:/Git/test.txt";
            StreamReader sr = new StreamReader(path);
            Lines.Add(sr.ReadLine());
            Lines.Add(sr.ReadLine());
            Console.WriteLine(PreExecLine(0) + "\n" + Lines[1] + sr.ReadToEnd());
            sr.Close();
        }

        public static void ExecLine(int i)
        {
        }

        public static string PreExecLine(int n)
        {
            char[] s = Lines[n].ToCharArray();
            int j = Lines[n].Length;
            bool rmWhiSpaces = Lines[n].Contains(':');
            if (rmWhiSpaces)
            {
                j = Array.IndexOf(s, ':');
                Lines.Insert(n + 1, Lines[n].Substring(j + 1, Lines[n].Length - j - 1).Trim());
            }

            Lines[n] = Lines[n].Substring(0, j + 1).Trim();
            if (rmWhiSpaces)
            {
                Lines[n] = Lines[n].Replace(" ", string.Empty);
            }

            return Lines[n];
        }

        public struct JumpPoint
        {
            public int LineId;
            public string PointName;
        }

        public struct VarSaved
        {
            public string Name;
            public long Num;
        }
    }
}
