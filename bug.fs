let mutable x = 1
let y = &x
!y <- 2
printf "%d" x //This will print 2 because of the mutable reference
x <- 3
printf "%d" !y // This will print 3 because y is referencing x, and x is mutable. 

//However, if x was not mutable
let x = 1
let y = &x //This will cause a compile-time error because you cannot take the address of a immutable variable in F#. 