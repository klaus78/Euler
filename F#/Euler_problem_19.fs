//You are given the following information, but you may prefer to do some research for yourself.
//
//    1 Jan 1900 was a Monday.
//    Thirty days has September,
//    April, June and November.
//    All the rest have thirty-one,
//    Saving February alone,
//    Which has twenty-eight, rain or shine.
//    And on leap years, twenty-nine.
//    A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
//
// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

// check if a year is leap
let isLeapYear year =
    (year % 4 = 0) || (year % 100 = 0 && year % 400 = 0)

// retun number of days in that year
let getNumDays year =
    let d1 = System.DateTime(year-1,12,31)
    let d2 = System.DateTime(year,12,31)
    int((d2-d1).TotalDays)


// number of the first days in a month that are sundays
let firstDaysMonthYear = [|1; 32; 60; 91; 121; 152; 182; 213; 244; 274; 305; 335 |]
let firstDaysMonthLeapYear = [|1; 32; 61; 92; 122; 153; 183; 214; 245; 275; 306; 336 |]

// return the number of sundays that falls on the first of a month 
// numFirstSunday = day number of first sunday of the year
// year = year to find the number of sundays
let rec getSundays numFirstSunday year counter =
    let isLeap = isLeapYear year
    let numDaysYear = getNumDays year
    let sundays = [numFirstSunday .. 7 .. numDaysYear]
    let lastSunday = List.last sundays
    let numSundaysBeginMonth =
        if isLeap then
            sundays |> List.filter(fun d -> Array.contains  d firstDaysMonthLeapYear) |> List.length
        else
            sundays |> List.filter(fun d -> Array.contains d firstDaysMonthYear ) |> List.length
    if year = 2000 then
        (counter + numSundaysBeginMonth)
    else
        // lets call the following year
        getSundays (lastSunday + 7 - numDaysYear) (year + 1) (counter + numSundaysBeginMonth)
		
[<EntryPoint>]
let main argv = 
    // first sunday in 1901 was day 1 of the year
    let res = getSundays 1 1901 0

	// res is 171
    printfn "%A" res