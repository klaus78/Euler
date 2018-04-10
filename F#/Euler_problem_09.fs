// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

// a^2 + b^2 = c^2
// For example, 3^2 + 4^2 = 9 + 16 = 25 = 52.

// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
// Find the product abc.

let isPythagorean a b c =
    if c < b then false
    elif b < a then false
    else a*a + b*b = c*c

let getPythagoreanTriplet = 
    seq {
        for a in seq{1..1000} do
            for b in seq{1..1000} do
                for c in seq{1..1000} do
                    if a+b+c=1000 && isPythagorean a b c then yield [a;b;c]
                    
    }
	
let res = getPythagoreanTriplet |> Seq.head

// result is 200,375,425