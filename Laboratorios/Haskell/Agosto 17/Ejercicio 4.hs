calcularPi :: Float -> Float
-- calcularPi se define haciendo que x tome el valor de todos los números que hay desde 0 hasta n. Esto significa que si n = 300, entonces la expresion se repetira 300 desde 0 hasta 300
calcularPi n = 4 * sum[((-1)**x) / ((2*x)+1) | x <- [0..n]]

main = do
    print (calcularPi 300)
