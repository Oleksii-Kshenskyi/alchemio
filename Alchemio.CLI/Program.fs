open System

let rec repl () =
    printf "<ALCH>>> "
    match Console.ReadLine() with
    | "exit" | "quit" | Null -> ()
    | input ->
        printfn "[Echo `%s`]" input
        repl ()

repl ()