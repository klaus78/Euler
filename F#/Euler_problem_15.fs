// Starting in the top left corner of a 2×2 grid, and only being able to move to 
// the right and down, there are exactly 6 routes to the bottom right corner.
// How many such routes are there through a 20×20 grid?

	
	let dimGrid = 20
    // create Array2D 20x20 with all 0s
    let grid = Array2D.init dimGrid dimGrid (fun i j -> 0L)
    // create Array with 1 except
    let arrayOnes = Array.init dimGrid (fun f -> 1L)
    arrayOnes.[arrayOnes.Length - 1] <- 0L
    grid.[dimGrid - 1,*] <- arrayOnes
    grid.[*, dimGrid - 1] <- arrayOnes
    let fromForeLastToFirst = [for i in 0..(dimGrid-2) do yield (dimGrid-2-i)]
    for x in fromForeLastToFirst do
        for y in fromForeLastToFirst do
            grid.[x,y] <-  grid.[x,y+1] + grid.[x+1,y]
    // sum all elements in the Array2D
    let result = grid |> Seq.cast<int64> |> Seq.sum
    printfn "%A" result
    
    // result is 137846528820L