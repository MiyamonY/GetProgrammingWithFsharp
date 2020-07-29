open System

let age = 35
let website = System.Uri "http://fsharp.org"
let add (first, second) = first + second

let foo () =
    let x = 10
    printfn "%d" (x + 20)
    let x = "test"
    let x = 50.0
    x + 200.0

let doStuffWithTwoNumbers (first, second) =
    let added = first + second
    Console.WriteLine("{0} + {1} = {2}", first, second, added)
    let doubled = added * 2
    doubled

let estimatedAge =
    let year = DateTime.Now.Year
    let age = year - 1979
    sprintf "You are about %d years old!" age

let estimateAges (familyName, year1, year2, year3) =
    let calculateAge yearOfBirth =
        let year = System.DateTime.Now.Year
        year - yearOfBirth

    let estimatedAge1 = calculateAge year1
    let estimatedAge2 = calculateAge year2
    let estimatedAge3 = calculateAge year3

    let averageAge =
        (estimatedAge1 + estimatedAge2 + estimatedAge3)
        / 3

    sprintf "Average age for family %s is %d" familyName averageAge

let generateRandomNumber max =
    let r = System.Random()
    let nextValue = r.Next(1, max)
    nextValue + 10


assert (let v = generateRandomNumber 10 in List.exists (fun x -> x = v) [ 10 .. 20 ])
