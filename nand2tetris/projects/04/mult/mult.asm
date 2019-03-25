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
    D=M
    @END
    D;JEQ
    @R1
    M=M-1
    @R0
    D=M
    @R2
    M=M+D
    @LOOP
    0;JMP // How does it know that the address in A is in the instruction address space or the data address space?
(END) 
    @END
    0;JMP
//Has a memory address in the instruction memory address space
// The infinite loop at the end is Hack's standard way to terminate
// the execution of Hack programs