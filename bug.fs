let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // Output: 20 10

// However, if you try to swap values in a function that takes them as arguments:

let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable a = ref 10
let mutable b = ref 20

swap2 a b
printfn "%d %d" !a !b //Output: 20 10

//Another example of mutable variables
let mutable z = 10
let addOne x = x <- x + 1

addOne z
printfn "%d" z //Output: 11

//If we want to have immutable variables, then we can use let instead of let mutable:
let z2 = 10
//addOne z2 //This will give an error because z2 is immutable