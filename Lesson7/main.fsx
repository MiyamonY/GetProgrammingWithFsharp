open System

let describeAge age =
    let ageDescription =
        if age < 18 then "Child!"
        elif age < 65 then "Adult!"
        else "OAP!"

    let greeting = "Hello"
    Console.WriteLine("{0} ! You are a '{1}'", greeting, ageDescription)

let writeTextToDisk text =
    let path = System.IO.Path.GetTempFileName()
    System.IO.File.WriteAllText(path, text)
    path

let createManyFiles () =
    writeTextToDisk "The quick brown fox jumped over the lazy dog"
    |> ignore
    writeTextToDisk "The quick brown fox jumped over the lazy dog"
    |> ignore
    writeTextToDisk "The quick brown fox jujped over the lazy dog"
    |> ignore

createManyFiles ()

let now =
    System.DateTime.UtcNow.TimeOfDay.TotalHours

if now < 12.0 then Console.WriteLine "It's morning"
elif now < 18.0 then Console.WriteLine "It's afternoon"
elif now < 20.0 then ignore (5 + 5)
else ()
