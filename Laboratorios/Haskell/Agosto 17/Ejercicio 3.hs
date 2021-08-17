-- Se usa esta función para determinar los factores de n
factores n = [ i | i <- [1..n-1], n `mod` i == 0]

nperfecto :: Integer -> String
nperfecto n -- Se determina si el número es perfecto
    | sum(factores n) == n = "El numero es perfecto" -- Si la suma de sus factores es igual al número, es perfecto
    | otherwise = "El numero no es perfecto" -- Si no son iguales a n, no es perfecto
    
main = do
-- Se evaluan los números para saber si son perfectos
    print ("2", nperfecto 2)
    print ("6", nperfecto 6)
    print ("21", nperfecto 21)
    print ("28", nperfecto 28)
    print ("99", nperfecto 99)
    print ("308", nperfecto 308)
    print ("496", nperfecto 496)
    print ("2001", nperfecto 2001)
    print ("8128", nperfecto 8128)
    print ("20301", nperfecto 20301)
    print ("1000000", nperfecto 1000000)
    print ("33550336", nperfecto 33550336)
