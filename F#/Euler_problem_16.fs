
// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

// What is the sum of the digits of the number 2^1000?

// convert float 2^1000 to bigint. Notice that the power operator ** works only with 
// floating point numbers
let n = bigint (2.0 ** 1000.0)
// convert bigint to string
let s = string n

let res = s |> Seq.map(fun c -> System.Numerics.BigInteger.Parse(c.ToString()))
            |> Seq.sum
// res is 1366