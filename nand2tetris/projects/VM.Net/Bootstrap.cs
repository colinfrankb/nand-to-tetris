﻿using System.Collections.Generic;

namespace VM.Net
{
    public class Bootstrap
    {
        public List<string> GenerateAssemblyInstructions()
        {
            return new List<string>
            {
                //Initialize a starting stack frame, to look like
                //Current ARG
                //Previous LCL
                //Previous ARG
                //Previous THIS
                //Previous THAT
                //Current LCL

                //Push an argument value onto the stack
                "@256",
                "M=-1",

                //Push the return address onto the stack
                "@257",
                "M=-1", // -1 is acceptable, because the Sys.init function does not perform a "return"

                //Push the base memory address of the previous local segment onto the stack
                "@258",
                "M=-1",

                //Push the base memory address of the previous argument segment onto the stack
                "@259",
                "M=-1",

                //Push the base memory address of the previous THIS segment onto the stack
                "@260",
                "M=-1",

                //Push the base memory address of the previous THAT segment onto the stack
                "@261",
                "M=-1",

                //Set the base addresses
                
                //Set SP
                "@262",
                "D=A",
                $"@{MemorySegments.SP}",
                "M=D",

                //Set ARG
                "@256",
                "D=A",
                $"@{MemorySegments.ARG}",
                "M=D",

                //Set LCL
                //LCL is set to the top of the stack. When the program jumps to the function instructions
                //the local variables will be pushed to the stack first, which is why LCL is set to
                //the top of the stack
                "@262",
                "D=A",
                $"@{MemorySegments.LCL}",
                "M=D",

                //The base memory addresses to the THIS and THAT segments are defined by the VM program, for example
                //function DoSomething 0
                //push constant 4001
                //pop pointer 0
                //push constant 5001
                //pop pointer 1
            };
        }
    }
}
