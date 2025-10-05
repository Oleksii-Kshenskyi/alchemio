namespace Alchemio.Core

open System
open DomainTypes

/// Contains the main logic and domain types of Alchemio.
/// This is the pure Core module.
/// ONLY pure functions are allowed here.
/// The Core only depends on Contracts, which expose shared types.
/// Rules for getting into the Core:
/// - No IO
/// - No side effects
/// - No mutable state
/// - No exceptions (error handling via monadic types)
/// - No third-party types or code.
/// Alchemio.Core.Interface module is the public-facing API of the Core assembly.
/// Alchemio.Core.Types should be treated as the domain specification of the game.
module Interface =
    let toWords (s:string) =
        s.Split(" ", StringSplitOptions.RemoveEmptyEntries)
        |> Array.toList

    let commandFromString (commandStr:string) =
        match toWords commandStr with
        | [] -> Empty
        | [""] -> Empty
        | ["exit" | "quit"] -> Exit 0uy
        | "echo" :: rest -> Echo (String.concat " " rest)
        | first :: _ -> Unknown first

