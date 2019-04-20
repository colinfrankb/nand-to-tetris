﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net.Commands
{
    public class Push : Command
    {
        private readonly string _segment;
        private readonly string _index;

        public Push(string segment, string index)
        {
            _segment = segment;
            _index = index;
        }

        public override IList<string> Execute(Stack stack)
        {
            var assemblyInstructions = new List<string>();

            if (_segment == "constant")
            {
                assemblyInstructions.Add($"@{_index}");
                assemblyInstructions.Add("D=A");
            }
            else if(_segment == "temp")
            {
                assemblyInstructions.Add($"@{MemorySegments.GetTempSymbol(_index)}");
                assemblyInstructions.Add("D=M");
            }
            else
            {
                assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols[_segment]}");
                assemblyInstructions.Add("D=M");
                assemblyInstructions.Add($"@{_index}");
                assemblyInstructions.Add("A=D+A");
                assemblyInstructions.Add("D=M");
            }

            assemblyInstructions.AddRange(stack.Push_D_OntoStack());

            return assemblyInstructions;
        }
    }
}
