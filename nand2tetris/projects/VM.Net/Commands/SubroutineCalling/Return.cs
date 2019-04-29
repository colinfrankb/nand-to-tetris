using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net.Commands.SubroutineCalling
{
    public class Return : Command
    {
        private readonly VMCommandsContext _context;

        public Return(VMCommandsContext context)
        {
            _context = context;
        }

        public override IList<string> Execute(Stack stack)
        {
            var assemblyInstructions = new List<string>();

            //FRAME = LCL
            //Save the base address of the local segment because that's
            //the top of the previous frame
            assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols["local"]}");
            assemblyInstructions.Add("D=M");
            assemblyInstructions.Add($"@{MemorySegments.R14}"); //using R14 for FRAME
            assemblyInstructions.Add("M=D");

            //RET = *(FRAME - 5), RET is return address
            assemblyInstructions.Add($"@5");
            assemblyInstructions.Add("D=D-A");
            assemblyInstructions.Add($"@{MemorySegments.R15}"); //using R15 for RET
            assemblyInstructions.Add("M=D");

            //*ARG = pop()
            //The return value of the completed function will be on top of the stack,
            //set ARG of the calling function to it, since the return value can be looked at,
            //
            assemblyInstructions.AddRange(stack.PopTo_D());
            assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols["argument"]}");
            assemblyInstructions.Add("A=M");
            assemblyInstructions.Add("M=D");

            //SP = ARG + 1
            assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols["argument"]}");
            assemblyInstructions.Add("D=M+1");
            assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols["stackpointer"]}");
            assemblyInstructions.Add("M=D");

            //THAT = *(FRAME - 1)
            //The asterix means the value in the memory address of the FRAME symbol is a memory address,
            //first subtract from the stack memory address, then get the value of the register at that memory address
            SetSegmentBaseStackAddress(assemblyInstructions, "that");
            
            //THIS = *(FRAME - 2)
            SetSegmentBaseStackAddress(assemblyInstructions, "this");
            
            //ARG = *(FRAME - 3)
            SetSegmentBaseStackAddress(assemblyInstructions, "argument");
            
            //LCL = *(FRAME - 4)
            SetSegmentBaseStackAddress(assemblyInstructions, "local");

            //goto RET
            assemblyInstructions.Add($"@{MemorySegments.R15}");
            assemblyInstructions.Add("0;JMP");

            return assemblyInstructions;
        }

        private void SetSegmentBaseStackAddress(IList<string> assemblyInstructions, string segment)
        {
            assemblyInstructions.Add($"@{MemorySegments.R14}");
            assemblyInstructions.Add("D=M");

            var offsetFromFrame = GetOffsetFromFrame(segment);

            assemblyInstructions.Add($"@{offsetFromFrame}");
            assemblyInstructions.Add("D=D-A");
            assemblyInstructions.Add("A=D");
            assemblyInstructions.Add("D=M");
            assemblyInstructions.Add($"@{MemorySegments.PredefinedSymbols[segment]}");
            assemblyInstructions.Add("M=D");
        }

        private int GetOffsetFromFrame(string segment)
        {
            switch (segment)
            {
                case "that":
                    return 1;
                case "this":
                    return 2;
                case "argument":
                    return 3;
                case "local":
                    return 4;
            }

            throw new ArgumentException("Segment not found in switch statement", segment);
        }
    }
}
