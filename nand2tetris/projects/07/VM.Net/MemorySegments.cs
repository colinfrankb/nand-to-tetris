using System;
using System.Collections.Generic;
using System.Text;

namespace VM.Net
{
    public class MemorySegments
    {
        private IDictionary<string, int> _memorySegments = new Dictionary<string, int>
        {
            { "argument", 0 },
            { "local", 0 },
            { "static", 0 },
            { "constant", 0 },
            { "this", 0 },
            { "that", 0 },
            { "pointer", 0 },
            { "temp", 0 }
        };

        // Segments mapped to memory
        // argument => Stack (256-2047)
        // local => Stack (256-2047)
        // static => Static RAM[16..255], which is the RAM address space used for 
        //           symbols (Variable Symbols and Label Symbols) found in an asm file.
        //           For the file Xxx.vm, push static 3, should be translated to 
        //           @Xxx.3
        //           D=M
        //           The Hack assembler will alocate RAM space, therefore no need to worry 
        //           about it in VM implementation
        // constant => not mapped, read arg2 as value
        // this => Heap (2048-16383)
        // that => Heap (2048-16383)
        // pointer[0..1] => Register RAM[3..4]
        // temp[0..7] => Register RAM[5..12]
    }
}
