// A palindromic number reads the same both ways. The largest palindrome made from the product of two
// 2-digit numbers is 9009 = 91 × 99. 

// Find the largest palindrome made from the product of two 3-digit numbers.

let isPalindromic (n:int) = 
    let s = n.ToString()
    let rev_s = s.ToCharArray() |> Array.rev |> System.String
    s = rev_s

let res = seq{
                for i in 100..999 do
                    for j in 100..999 do
                        if isPalindromic(i*j) then 
							yield(i*j)
             } |> 
             Seq.max
// result is 906609