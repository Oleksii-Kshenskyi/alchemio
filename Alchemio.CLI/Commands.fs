module Commands

open System

type Command =
    | Empty
    | Unknown of string
    | Echo of string
    | Exit of uint8

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