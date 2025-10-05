namespace Alchemio.CLI

open System

open Alchemio.Core.Interface
open Alchemio.Core.DomainTypes

/// This is the CLI module. Main purpose is: REPL, CLI interface, IO.
/// IO, imperative code and any other impurities are allowed here.
/// Working with C# and thirdparty code should be isolated to the
/// Adapters project and only invoked from here to glue everything together
/// for IO/UX purposes.
/// Uses:
/// - Core for domain types and logic;
/// - Adapters for third-party and C# code (dependencies);
/// Only composes the dependencies and applies IO.
/// Does not contain logic or computations, is an impure 
/// constructor/consumer module.

module Repl = 

    let rec repl () =
        printf "<ALCH>>> "
        match commandFromString (Console.ReadLine()) with
        | Empty -> ()
        | Exit code -> Environment.Exit(int code)
        | Echo what -> printfn "`%s`" what
        | Unknown cmd -> printfn "[???] What is `%s`?" cmd
        repl ()

    repl ()