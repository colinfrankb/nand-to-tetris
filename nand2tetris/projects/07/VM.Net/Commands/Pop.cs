using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net.Commands
{
    public class Pop : Command
    {
        private readonly string _segment;
        private readonly string _index;

        public Pop(string segment, string index)
        {
            _segment = segment;
            _index = index;
        }

        public override IList<string> Execute(Stack stack)
        {
            var assemblyInstructions = new List<string>();

            if (_segment == "temp")
            {
                assemblyInstructions.AddRange(stack.PopTo_D());

                //Save to target memory address
                assemblyInstructions.Add($"@{MemorySegments.GetTempSymbol(_index)}");
                assemblyInstructions.Add("M=D");
            }
            else
            {
                //Calculate target memory address
                assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols[_segment]}");
                assemblyInstructions.Add($"D=M");
                assemblyInstructions.Add($"@{_index}");
                assemblyInstructions.Add($"D=D+A");
                assemblyInstructions.Add($"@{MemorySegments.R15}");
                assemblyInstructions.Add($"M=D");

                assemblyInstructions.AddRange(stack.PopTo_D());

                //Save to target memory address
                assemblyInstructions.Add($"@{MemorySegments.R15}");
                assemblyInstructions.Add($"A=M");
                assemblyInstructions.Add($"M=D");
            }

            return assemblyInstructions;
        }
    }
}
