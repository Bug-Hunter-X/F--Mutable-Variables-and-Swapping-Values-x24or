let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // Output: 20 10

// Correct way to swap values in a function using ref cells
let swap2 (x:int ref) (y:int ref) = 
    let temp = !x
    x := !y
    y := temp

let mutable a = ref 10
let mutable b = ref 20

swap2 a b
printfn "%d %d" !a !b //Output: 20 10

// Immutable example (preferred approach for better code clarity and avoiding side-effects)
let swap3 x y = (y, x)

let a2 = 10
let b2 = 20
let (a3, b3) = swap3 a2 b2
printfn "%d %d" a3 b3 // Output: 20 10