-- Se usa esta función para determinar los factores de n
factores n = [ i | i <- [1..n-1], n `mod` i == 0]

nperfecto :: Integer -> String
nperfecto n -- Se determina si el número es perfecto
    | sum(factores n) == n = "El numero es perfecto" -- Si la suma de sus factores es igual al número, es perfecto
    | otherwise = "El numero no es perfecto" -- Si no son iguales a n, no es perfecto
    
main = do
-- Se evaluan los números para saber si son perfectos
    print ("Digite un numero")
    input <- getLine
    let num = read input
    print (nperfecto num)
