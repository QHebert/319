import System.IO
sumar :: Double ->Double->Double
sumar x y = x+y
restar x y = x-y
multiplicar x y = x*y
dividir x y |y/=0 = x/y 
            |otherwise =0
main = do
    a<-getLine 
    b<-getLine 
    print(sumar (read a) (read b))
    print(restar  (read a) (read b))
    print(multiplicar  (read a) (read b))
    print(dividir  (read a) (read b))