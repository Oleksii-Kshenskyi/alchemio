namespace Alchemio.Core

module DomainTypes = 

    type Command =
    | Empty
    | Unknown of string
    | Echo of string
    | Exit of uint8

