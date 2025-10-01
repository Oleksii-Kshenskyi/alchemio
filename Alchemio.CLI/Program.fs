open System
open Commands

let rec repl () =
    printf "<ALCH>>> "
    match commandFromString (Console.ReadLine()) with
    | Empty -> ()
    | Exit code -> Environment.Exit(int code)
    | Echo what -> printfn "`%s`" what
    | Unknown cmd -> printfn "[???] What is `%s`?" cmd
    repl ()

repl ()