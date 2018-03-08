// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

let findFactors (n:int64) =
    seq {let square = int64(sqrt (float n))
    for i in 2L..square do
        if n%i = 0L then yield i}

// taken from 
// http://www.fssnip.net/3X
let isPrime n =
  let sqrt' = (float >> sqrt >> int64) n // square root of integer
  [ 2L .. sqrt' ] // all numbers from 2 to sqrt'
  |> List.forall (fun x -> n % x <> 0L) // no divisors

  
let res = findFactors 600851475143L
		  |> Seq.filter(fun n -> isPrime n)
		  |> Seq.max

// res is 6857
