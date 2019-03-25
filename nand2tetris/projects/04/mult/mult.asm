// Multiplies R0 and R1 and stores the result in R2.
// (R0, R1, R2 refer to RAM[0], RAM[1], and RAM[2], respectively.)

//A-Instruction: @value
//C-Instruction: dest=comp;jump

// Algebraic
// RO × R1 = R2
    @R2
    M=0
(LOOP) //Has a memory address in the instruction memory address space
    @R1
    MD=M-1
    @END
    D;JLT
    @R0
    D=M
    @R2
    M=M+D
    @LOOP
    0;JMP // How does it know that the address in A is in the instruction address space or the data address space?
(END) 
    @END
    0;JMP
// Has a memory address in the instruction memory address space
// The infinite loop at the end is Hack's standard way to terminate
// the execution of Hack programs

// The instruction's code is mapped to addresses from 0 to n
// The assembled binary code file will only contains lines for each
// instruction.
// Label symbols do not map to instructions