open System

[<EntryPoint>]
let main argv =
    let welcomeMessage = Day00.welcomeMessage 0
    printfn $"%s{welcomeMessage}"
    Console.ReadLine() |> ignore
    0