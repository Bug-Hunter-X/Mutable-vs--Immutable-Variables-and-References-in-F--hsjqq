let mutable x = 1
let y = &x
!y <- 2
printf "%d" x //Prints 2
x <- 3
printf "%d" !y //Prints 3

//Alternatively, you can avoid mutability altogether if the modification isn't essential and achieve better immutability and thread-safety:
let x = 1
let y = x //No reference needed; y is a copy of x.
let z = y + 1 //creates a new value without modifying x. 
printf "%d" x; //Prints 1. x remains unchanged.