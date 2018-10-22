// n! means n × (n − 1) × ... × 3 × 2 × 1
// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
// Find the sum of the digits in the number 100!


// find n!
let rec fact n : bigint =
    match n with 
    | 0 | 1 -> 1I
    | _ -> bigint(n) * fact (n-1)


[<EntryPoint>]
let main argv = 

    let n = fact 100
    let s = n.ToString()

    let res = 
        s 
        // convert each char to a bigint
        |> Seq.map(fun c -> bigint(System.Char.GetNumericValue(c))) 
        // sum 
        |> Seq.sum
    printfn "%A" res
	// result is 648
    