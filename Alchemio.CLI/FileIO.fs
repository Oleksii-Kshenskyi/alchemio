module Alchemio.FileIO

open System.IO

let fileLines filename = File.ReadAllLines filename
