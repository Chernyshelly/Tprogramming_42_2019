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
            Console.WriteLine(PreExecLine(0) + "\n" + sr.ReadToEnd());
            sr.Close();
        }

        public static void ExecLine(int i)
        {
        }

        public static string PreExecLine(int n)
        {
            char[] s = Lines[n].ToCharArray();
            int j = Array.IndexOf(s, ':');
            s[j + 1] = '\n';
            int i = 0;
            while ((s[i] == ' ') && (i < s.Length))
            {
                i++;
            }

            string ss = string.Empty;
            for (int ii = i; ii < s.Length; ii++)
            {
                ss += s[ii];
            }

            Lines[n] = ss;
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
