// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let suma a b = a+b
    let resta a b = a-b
    let multiplicasion a b = a*b
    let division a b = 
        if b>0.0 then a/b else 0.0

    Console.WriteLine "Introduce a"
    let a = Double.Parse( Console.ReadLine())
    Console.WriteLine "Introduce b"
    let b = Double.Parse(Console.ReadLine())
    
    Console.Write("la suma es:") 
    Console.WriteLine(suma a b)
    Console.Write("la resta es:") 
    Console.WriteLine(resta a b)
    Console.Write("la multiplicasion es:") 
    Console.WriteLine(multiplicasion a b)
    Console.Write("la division es:") 
    Console.WriteLine(division a b)
    let res = Console.ReadKey()
    0 // return an integer exit code
