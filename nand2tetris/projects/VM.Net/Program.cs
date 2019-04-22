using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VM.Net.Commands;

namespace VM.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(args[0]);
            var fileDirectoryName = Path.GetDirectoryName(args[0]);
            string[] lines = File.ReadAllLines(args[0]);

            var commandFactory = new CommandFactory();
            var parser = new Parser(commandFactory);
            var stack = new Stack();

            var commands = parser.ParseVMCommands(new VMCommandsContext { FileName = fileNameWithoutExtension }, lines);

            Console.WriteLine($"{commands.Count()} commands found.");

            var assemblyInstructions = commands.Aggregate(new List<string>(), (a, c) => 
            {
                a.AddRange(c.Execute(stack));
                return a;
            });

            Console.WriteLine($"{assemblyInstructions.Count()} assembly instructions generated.");

            File.WriteAllLines($"{fileDirectoryName}\\{fileNameWithoutExtension}.asm", assemblyInstructions);
        }


        public class Parser
        {
            private readonly CommandFactory _commandFactory;

            public Parser(CommandFactory commandFactory)
            {
                _commandFactory = commandFactory;
            }

            public IEnumerable<Command> ParseVMCommands(VMCommandsContext context, string[] lines)
            {
                var remainingLines = StripComments(lines);

                return remainingLines.Select(line => _commandFactory.Create(context, line));
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
