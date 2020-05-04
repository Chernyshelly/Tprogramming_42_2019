using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    public class Program
    {
        public enum LineType
        {
            Label,
            Condition,
            Math,
            Direction,
            Printing,
            Reading,
            Undefined
        }

        public static List<LineReady> Lines { get; set; } = new List<LineReady>();

        public static List<VarSaved> Vars { get; set; } = new List<VarSaved>();

        public static List<JumpPoint> JumpPlaces { get; set; } = new List<JumpPoint>();

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = "d:/Git/test.txt";
            StreamReader sr = new StreamReader(path);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                PreExecLine(line);
            }

            sr.Close();
            foreach (var item in Lines)
            {
                Console.WriteLine($"{item.Line} : {item.Type}");
            }

            ExecLine(0);
            Console.WriteLine($"{JumpPlaces[0].PointName} : {JumpPlaces[0].LineId}");
        }

        public static void ExecLine(int i)
        {
            switch (Lines[i].Type)
            {
                case LineType.Label: SpecTypesExec.ExecLabel(i); break;
            }
        }

        public static void PreExecLine(string line)
        {
            char[] s = line.ToCharArray();
            int j = line.Length;
            LineReady rdyLine;
            rdyLine.Line = line;
            rdyLine.Type = LineType.Undefined;
            Lines.Add(rdyLine);
            int i = Lines.LastIndexOf(rdyLine);
            bool label = line.Contains(':');
            if (label)
            {
                rdyLine.Type = LineType.Label;
                j = Array.IndexOf(s, ':');
                PreExecLine(line.Substring(j + 1, line.Length - j - 1).Trim());
            }

            string retLine = line.Substring(0, j).Trim();
            if (label)
            {
                retLine = retLine.Replace(" ", string.Empty);
            }

            if (retLine.StartsWith("if "))
            {
                rdyLine.Type = LineType.Condition;
            }
            else if (retLine.StartsWith("goto "))
            {
                rdyLine.Type = LineType.Direction;
            }
            else if (retLine.Contains("="))
            {
                rdyLine.Type = LineType.Math;
            }
            else if (retLine.StartsWith("print "))
            {
                rdyLine.Type = LineType.Printing;
            }
            else if (retLine.StartsWith("read "))
            {
                rdyLine.Type = LineType.Reading;
            }
            else if (retLine.Contains(':'))
            {
                rdyLine.Type = LineType.Label;
            }

            rdyLine.Line = retLine;
            Lines[i] = rdyLine;
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

        public struct LineReady
        {
            public LineType Type;
            public string Line;
        }
    }
}
