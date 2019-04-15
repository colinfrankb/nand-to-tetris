using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net.Commands
{
    public class Push
    {
        public string Execute(Stack stack, string segment, int index)
        {
            var assemblyInstructions = new StringBuilder();

            assemblyInstructions.Append(stack.PushD());

            return assemblyInstructions.ToString();
        }
    }
}
