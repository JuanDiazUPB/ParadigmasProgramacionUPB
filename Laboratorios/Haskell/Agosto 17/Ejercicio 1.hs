-- Se definen los tipos de datos de las variables en la ecuación
ecupositiva :: Float -> Float -> Float -> Float
-- Se define la variable para calcular la ecuación positiva
ecupositiva a b c = (-b + sqrt((b**2) - (4 * a * c))) / (2 * a)

ecunegativa :: Float -> Float -> Float -> Float
-- Se define la variable para calcular la ecuación negativa
ecunegativa a b c = (-b - sqrt((b**2) - (4 * a * c))) / (2 * a)

main = do
    -- Se le asignan los valores a "a, b y c"
    print (ecunegativa 4 8 3)
    print (ecupositiva 4 8 3)
    -- Solo se pueden interpretar resultados reales
