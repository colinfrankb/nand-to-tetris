@256
M=-1
@257
M=-1
@258
M=-1
@259
M=-1
@260
M=-1
@261
D=A
@SP
M=D
@261
D=A
@LCL
M=D
@256
D=A
@ARG
M=D
@3000
D=A
@THIS
M=D
@4000
D=A
@THAT
M=D
(Sys.init)
@6
D=A
@SP
A=M
M=D
@SP
M=M+1
@8
D=A
@SP
A=M
M=D
@SP
M=M+1
@b2ff65b2-67f3-4073-a65d-da4a27f8c218
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@SP
A=M
M=D
@SP
M=M+1
@ARG
D=M
@SP
A=M
M=D
@SP
M=M+1
@THIS
D=M
@SP
A=M
M=D
@SP
M=M+1
@THAT
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
D=M
@2
D=D-A
@5
D=D-A
@ARG
M=D
@SP
D=M
@LCL
M=D
@Class1.set
0;JMP
(b2ff65b2-67f3-4073-a65d-da4a27f8c218)
@SP
A=M-1
D=M
@SP
M=M-1
@R5
M=D
@23
D=A
@SP
A=M
M=D
@SP
M=M+1
@15
D=A
@SP
A=M
M=D
@SP
M=M+1
@e0b5290b-661c-465f-a9a4-95a9f960c7a1
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@SP
A=M
M=D
@SP
M=M+1
@ARG
D=M
@SP
A=M
M=D
@SP
M=M+1
@THIS
D=M
@SP
A=M
M=D
@SP
M=M+1
@THAT
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
D=M
@2
D=D-A
@5
D=D-A
@ARG
M=D
@SP
D=M
@LCL
M=D
@Class2.set
0;JMP
(e0b5290b-661c-465f-a9a4-95a9f960c7a1)
@SP
A=M-1
D=M
@SP
M=M-1
@R5
M=D
@bca31126-6410-4f7f-91ec-c6765f331898
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@SP
A=M
M=D
@SP
M=M+1
@ARG
D=M
@SP
A=M
M=D
@SP
M=M+1
@THIS
D=M
@SP
A=M
M=D
@SP
M=M+1
@THAT
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
D=M
@0
D=D-A
@5
D=D-A
@ARG
M=D
@SP
D=M
@LCL
M=D
@Class1.get
0;JMP
(bca31126-6410-4f7f-91ec-c6765f331898)
@ce864c82-ad85-4035-8f7d-a493957bcb19
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@SP
A=M
M=D
@SP
M=M+1
@ARG
D=M
@SP
A=M
M=D
@SP
M=M+1
@THIS
D=M
@SP
A=M
M=D
@SP
M=M+1
@THAT
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
D=M
@0
D=D-A
@5
D=D-A
@ARG
M=D
@SP
D=M
@LCL
M=D
@Class2.get
0;JMP
(ce864c82-ad85-4035-8f7d-a493957bcb19)
(Sys.init$WHILE)
@Sys.init$WHILE
0;JMP
(Class1.set)
@ARG
D=M
@0
A=D+A
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@Class1.0
M=D
@ARG
D=M
@1
A=D+A
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@Class1.1
M=D
@0
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@R14
M=D
@5
D=D-A
A=D
D=M
@R15
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@ARG
A=M
M=D
@ARG
D=M+1
@SP
M=D
@R14
D=M
@1
D=D-A
A=D
D=M
@THAT
M=D
@R14
D=M
@2
D=D-A
A=D
D=M
@THIS
M=D
@R14
D=M
@3
D=D-A
A=D
D=M
@ARG
M=D
@R14
D=M
@4
D=D-A
A=D
D=M
@LCL
M=D
@R15
A=M
0;JMP
(Class1.get)
@Class1.0
D=M
@SP
A=M
M=D
@SP
M=M+1
@Class1.1
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@R14
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@R14
D=D-M
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@R14
M=D
@5
D=D-A
A=D
D=M
@R15
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@ARG
A=M
M=D
@ARG
D=M+1
@SP
M=D
@R14
D=M
@1
D=D-A
A=D
D=M
@THAT
M=D
@R14
D=M
@2
D=D-A
A=D
D=M
@THIS
M=D
@R14
D=M
@3
D=D-A
A=D
D=M
@ARG
M=D
@R14
D=M
@4
D=D-A
A=D
D=M
@LCL
M=D
@R15
A=M
0;JMP
(Class2.set)
@ARG
D=M
@0
A=D+A
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@Class2.0
M=D
@ARG
D=M
@1
A=D+A
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@Class2.1
M=D
@0
D=A
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@R14
M=D
@5
D=D-A
A=D
D=M
@R15
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@ARG
A=M
M=D
@ARG
D=M+1
@SP
M=D
@R14
D=M
@1
D=D-A
A=D
D=M
@THAT
M=D
@R14
D=M
@2
D=D-A
A=D
D=M
@THIS
M=D
@R14
D=M
@3
D=D-A
A=D
D=M
@ARG
M=D
@R14
D=M
@4
D=D-A
A=D
D=M
@LCL
M=D
@R15
A=M
0;JMP
(Class2.get)
@Class2.0
D=M
@SP
A=M
M=D
@SP
M=M+1
@Class2.1
D=M
@SP
A=M
M=D
@SP
M=M+1
@SP
A=M-1
D=M
@SP
M=M-1
@R14
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@R14
D=D-M
@SP
A=M
M=D
@SP
M=M+1
@LCL
D=M
@R14
M=D
@5
D=D-A
A=D
D=M
@R15
M=D
@SP
A=M-1
D=M
@SP
M=M-1
@ARG
A=M
M=D
@ARG
D=M+1
@SP
M=D
@R14
D=M
@1
D=D-A
A=D
D=M
@THAT
M=D
@R14
D=M
@2
D=D-A
A=D
D=M
@THIS
M=D
@R14
D=M
@3
D=D-A
A=D
D=M
@ARG
M=D
@R14
D=M
@4
D=D-A
A=D
D=M
@LCL
M=D
@R15
A=M
0;JMP
