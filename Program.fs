let a0 = 1
let q = 2
let n = 1025

let rec calc a=
    if a < n then 
        printf $"{a} " 
        calc (a * q)
    else printfn "End"

calc a0
