// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

// functions that returns true if n can be divided by each
// of the numbers from 1 to m
let isEvenlyDivisible n m =
    seq{1..m} |>
    Seq.filter(fun i -> n%i = 0)
    |> Seq.length = m
	
let maxDiv = 20
let res = 
	// generate sequence 0, 20, 40, 60 ....
	Seq.initInfinite(fun n -> n*maxDiv)
	|> Seq.filter(fun n -> n > 0)
	|> Seq.filter(fun n -> isEvenlyDivisible n maxDiv)
	|> Seq.head
		
// result is 232792560
printfn "%A" res