module FileUtils

open System.IO

let fileLines filename = File.ReadAllLines filename
