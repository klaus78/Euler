// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
// What is the 10001st prime number?

// brute force algorithm to check if n is prime
let isPrime n =
    seq{2L..(n-1L)} 
    |> Seq.filter(fun i -> n%i = 0L)
    |> Seq.length = 0
	
let res = 
		// generate infinite sequence of numbers starting from 2
        Seq.initInfinite (fun index -> int64(index+2))
        // filter the prime numbers
        |> Seq.filter(fun n -> isPrime n)
        // take 10001 prime numbers
        |> Seq.take(10001)
        // take the last, ie the 10001th
        |> Seq.last

// result is 104743L