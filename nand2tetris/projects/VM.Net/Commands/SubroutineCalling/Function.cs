using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net.Commands.SubroutineCalling
{
    public class Function : Command
    {
        private readonly VMCommandsContext _context;
        private readonly string _functionName;
        private readonly int _k_localVariables;

        public Function(VMCommandsContext context, string functionName, string k_localVariables)
        {
            _context = context;
            _functionName = functionName;
            _k_localVariables = Convert.ToInt32(k_localVariables);
        }

        public override IList<string> Execute(Stack stack)
        {
            var assemblyInstructions = new List<string>();

            //Declare a Label Symbol for the function entry
            assemblyInstructions.Add($"({_functionName})");

            //Allocate space on the stack for local variables, initialised to 0
            var push = new Push(_context, "constant", "0");
            var pushAssemblyInstructions = push.Execute(stack);
            for (int i = 0; i < _k_localVariables; i++)
            {
                assemblyInstructions.AddRange(pushAssemblyInstructions);
            }

            return assemblyInstructions;
        }
    }
}
