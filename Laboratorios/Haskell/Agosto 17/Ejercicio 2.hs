suma :: Integer -> Integer -> Integer
-- Se establece el inicio y final del algoritmo
suma a b
    | a == b = b -- Se prueba si a = b
    | otherwise = a + suma (a+1) b -- Si no lo es, a se suma con si mismo mas 1, tal que a + (a+1), y el proceso se repite hasta que a = b
    
main = do
    print (suma 20 30)
-- La suma de todos los números entre 20 y 30 (estos incluidos) da como resultado 275
