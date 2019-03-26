// This file is part of www.nand2tetris.org
// and the book "The Elements of Computing Systems"
// by Nisan and Schocken, MIT Press.
// File name: projects/04/Fill.asm

// Runs an infinite loop that listens to the keyboard input.
// When a key is pressed (any key), the program blackens the screen,
// i.e. writes "black" in every pixel;
// the screen should remain fully black as long as the key is pressed. 
// When no key is pressed, the program clears the screen, i.e. writes
// "white" in every pixel;
// the screen should remain fully clear as long as no key is pressed.

// Let R1 point to the pixel value (pixel = 1 is black, 0 is white)
// Let R2 point to the screen loop counter, starting at -1

(MAINLOOP)
    @R1
    M=0
    @R2
    M=-1
    @KBD
    D=M
    @BLACK
    D;JNE
(SCREENLOOP)
    @R2
    MD=M+1
    @8192
    D=D-A
    @MAINLOOP // Following convention of breaking out of loop first
    D;JGE
    @R2
    D=M
    @SCREEN
    D=A+D
    @R3
    M=D // Place the target memory word address into a register
    @R1
    D=M // Load the pixel value
    @R3
    A=M
    M=D
    @SCREENLOOP
    0;JMP
(BLACK)
    @R1
    M=-1
    @SCREENLOOP
    0;JMP

// Observations while coding functions
// The function must appear at the end of all functionality
// because the instructions are read one line after another
