load Jump.hdl,
output-file Jump.out,
compare-to Jump.cmp,
output-list j1%B3.1.3 j2%B3.1.3 j3%B3.1.3 zr%B3.1.3 ng%B3.1.3 out%B3.1.3;

set j1 0,
set j2 0,
set j3 1,
set zr 0,
set ng 0,
eval,
output;

set j1 0,
set j2 1,
set j3 0,
set zr 1,
set ng 0,
eval,
output;

set j1 0,
set j2 1,
set j3 1,
set zr 1,
set ng 0,
eval,
output;

set j1 1,
set j2 0,
set j3 0,
set zr 0,
set ng 1,
eval,
output;

//region JNE if out != 0, therefore zr should be 0 and ng should be (0 or 1)
set j1 1,
set j2 0,
set j3 1,
set zr 0,
set ng 0,
eval,
output;

set j1 1,
set j2 0,
set j3 1,
set zr 0,
set ng 1,
eval,
output;
//end region

set j1 1,
set j2 1,
set j3 0,
set zr 1,
set ng 1,
eval,
output;

set j1 1,
set j2 1,
set j3 1,
set zr 0,
set ng 0,
eval,
output;