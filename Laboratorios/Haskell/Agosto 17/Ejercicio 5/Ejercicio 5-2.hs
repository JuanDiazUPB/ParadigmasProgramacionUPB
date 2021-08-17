suma :: Integer -> Integer -> Integer
-- Se establece el inicio y final del algoritmo
suma a b
    | a == b = b -- Se prueba si a = b
    | otherwise = a + suma (a+1) b -- Si no lo es, a se suma con si mismo mas 1, tal que a + (a+1), y el proceso se repite hasta que a = b
    
main = do
    print ("Digite donde quiere que inicie el algoritmo")
    inicio <- getLine
    let a = read inicio
    print ("Digite donde quiere que acabe el algoritmo")
    final <- getLine
    let b = read final
    print (suma a b)
