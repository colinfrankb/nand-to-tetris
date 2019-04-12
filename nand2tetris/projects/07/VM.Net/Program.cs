using System;
using System.Collections.Generic;
using System.IO;

namespace VM.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(args[0]);

            var parser = new Parser();

            var assemblyInstructions = parser.ParseVMCommands(lines);

            // Implement Memory Segments as a dictionary
            // Implement VM Commands as individual classes
            // Implement assembly code for each VM Command
            // The VM Commands will reach into the memory segments

            File.WriteAllLines($"{args[0].Split('.')[0]}.asm", assemblyInstructions);
        }


        public class Parser
        {
            public IList<string> ParseVMCommands(string[] lines)
            {
                var remainingLines = StripComments(lines);

                return remainingLines;
            }

            private IList<string> StripComments(string[] lines)
            {
                var remainingLines = new List<string>();

                for (int i = 0; i < lines.Length; i++)
                {
                    var assemblyInstruction = GetNonComment(lines[i]);

                    if (string.IsNullOrWhiteSpace(assemblyInstruction))
                    {
                        continue;
                    }

                    remainingLines.Add(assemblyInstruction);
                }

                return remainingLines;
            }

            private string GetNonComment(string line)
            {
                var indexOfComment = line.IndexOf("//");

                if (indexOfComment > -1)
                {
                    line = line.Substring(0, Math.Max(0, indexOfComment));
                }

                return line.Trim();
            }
        }
    }
}
