-- Se definen los tipos de datos de las variables en la ecuación
ecupositiva :: Float -> Float -> Float -> Float
-- Se define la variable para calcular la ecuación positiva
ecupositiva a b c = (-b + sqrt((b**2) - (4 * a * c))) / (2 * a)

ecunegativa :: Float -> Float -> Float -> Float
-- Se define la variable para calcular la ecuación negativa
ecunegativa a b c = (-b - sqrt((b**2) - (4 * a * c))) / (2 * a)

main = do
    print ("Digite un valor para a")
    inputa <- getLine
    let a = read inputa
    print ("Digite un valor para b")
    inputb <- getLine
    let b = read inputb
    print ("Digite un valor para c")
    inputc <- getLine
    let c = read inputc
    
    print (ecunegativa a b c)
    print (ecupositiva a b c)