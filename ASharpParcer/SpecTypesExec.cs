using System;
using System.IO;
using System.Collections.Generic;

namespace ASharpParcer
{
    public static class SpecTypesExec
    {
        public static void ExecLabel(int lineNum)
        {
            Program.JumpPoint jp;
            jp.LineId = lineNum;
            jp.PointName = Program.Lines[lineNum].Line.Substring(0, Program.Lines[lineNum].Line.Length);
            if (!Program.JumpPlaces.Contains(jp))
            {
                Program.JumpPlaces.Add(jp);
            }
        }
    }
}
