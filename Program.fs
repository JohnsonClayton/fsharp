﻿// Learn more about F# at http://fsharp.org
// The code here is used as demonstration code on Derek Banas's YouTube channel: https://www.youtube.com/watch?v=c7eNDJN758U


open System

let hello() = 
    printf "Enter your name: "

    let name = Console.ReadLine()   // Reads line from console

    printfn "Hello, %s" name        // Statically-typed print %s => string, this operates in a similar way to C

let paddingexample() = 
    printfn "%-10s %10s" "col 1" "col 2"
    printfn"%-*s %*s" 10 "col 1" 10 "col 2"

let bindstuff() = 
    let mutable weight = 175    // mutable lets us change this value
    printfn "Weight: %i" weight
    
    weight <- 170
    printfn "Weight: %i" weight

    let changeme = ref 10
    printfn "Change: %i" ! changeme

    changeme := 50
    printfn "Change: %i" ! changeme

let dofuncs() =
    // function (arg_name : arg_type ...) : return_type = definition
    let getsum (x: int, y: int) : int = x + y
    printfn "5 + 7 = %i" (getsum(5, 7))

    // Recursive function example for factorial
    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x - 1)

    printfn "Factorial of 4: %i" (factorial 4)

    // Lambda expressions
    let randlist = [ 1; 2; 3]
    let randlist2 = List.map( fun x -> x*2 ) randlist

    printfn "Normal list: %A" randlist
    printfn "Doubled list: %A" randlist2


    // Piping operations 
    //  We have this integer list, then we filter off all the values that are even (v%2)=0 is True,
    // then, we take all of the values resulting from this, double them, then pass them to printfn
    [5; 6; 7; 8]
    |> List.filter( fun v -> (v % 2) = 0 )
    |> List.map( fun x -> x * 2)
    |> printfn "Even numbers doubled: %A" 


    // Weird function stuff
    let multnum x = x * 3
    let addnum y = y + 5

    let multadd = multnum >> addnum
    let addmult = multnum << addnum

    printfn "multiply then add: %i" (multadd 10)
    printfn "add then multiple: %i" (addmult 10)

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    hello()
    paddingexample()
    bindstuff()
    dofuncs()

    printf "To exit, press any key...\n"
    Console.ReadKey() |> ignore   // Will spin until keypress occurs
    0 // return an integer exit code