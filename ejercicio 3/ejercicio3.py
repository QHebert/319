from pyswip import Prolog
prolog = Prolog()
prolog.consult("padre.pl")
for soln in prolog.query("abuelo(X,Y)"):
    print(soln["X"], " es abuelo de ", soln["Y"])

for soln in prolog.query("nieto(X,Y)"):
    print(soln["X"], " es nieto(a) de ", soln["Y"])

for soln in prolog.query("primos(X,Y)"):
    print(soln["X"], " y ", soln["Y"], "son primos ")