#!/usr/bin/env fsharpi
// run:
//   dotnet fsi --define:DEBUG main.fsx
open System

let text = "Hello, world"

let greetPerson name age =
    sprintf "Hello, %s. You are %d years old." name age

let greeting = greetPerson "Fred" 25

assert (greeting = "Hello, Fred. You are 25 years old.")

let countWords (text: string) = text.Split(" ") |> Array.length

assert (countWords ("a b c") = 3)
