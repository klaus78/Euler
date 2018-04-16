// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
//
// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

// return length in chars of a number between 1 and 1000
let rec countChars n =
    match n with
    | 0 -> 4
    | (1 | 2) -> 3
    | 3 -> 5
    | (4 | 5) -> 4
    | 6 -> 3
    | (7 | 8) -> 5
    | 9 -> 4
    | 10 -> 3
    | (11 | 12) -> 6
    | (13 | 14) -> 8
    | (15 | 16) -> 7
    | 17 -> 9
    | (18 | 19) -> 8
    | (20 | 30) -> 6 
    | (40 | 50 | 60) -> 5 
    | 70 -> 7 
    | (80 | 90) -> 6 
    | x when (x >= 21) && (x <= 99) && (x % 10 <> 0) -> 
            (
                let tensDigit = x / 10
                let singleDigit = x % 10
                (countChars (tensDigit * 10)) + (countChars singleDigit)
            )
    | x when x >= 100 && x <= 999 ->
        (
            let hundredDigit = x / 100
            // 7 is the length of "hundred"
            let hundredNChars = countChars (hundredDigit) + 7
            let withoutHundred = x - hundredDigit * 100
            match withoutHundred with
                | 0 -> hundredNChars
                // 3 is the length of "and" like 453 = four hundred and twenty three
                | _ -> hundredNChars + 3 + countChars (withoutHundred)
        )
    | 1000 -> 11
    | _ -> failwith ("Number smaller than 0 and langers than 1000 are not accepted")

let res = 
	seq {1..1000}
	|> Seq.map(fun n -> countChars n)
	|> Seq.sum
	
	// result is 21124