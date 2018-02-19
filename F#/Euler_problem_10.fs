// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//
// Find the sum of all the primes below two million.

let isPrime (n:int64) =
    match n with
    | _ when n > 3L && (n % 2L = 0L || n % 3L = 0L) -> false
    | _ ->
        let maxDiv = int64(System.Math.Sqrt(float n)) + 1L
        let rec f d i = 
            if d > maxDiv then 
                true
            else
                if n % d = 0L then 
                    false
                else
                    f (d + i) (6L - i)     
        f 5L 2L

// result
seq{2L..2000000L}
|> Seq.filter(fun n -> isPrime n)
|> Seq.sum

// result is 142913828922
