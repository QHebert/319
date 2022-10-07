
hombre(maximo).
hombre(felix).
hombre(jaime).
hombre(hebert).
hombre(edwin).
hombre(jordy).
hombre(david).
hombre(andres).

mujer(magdalena).
mujer(maria).
mujer(victoria).
mujer(evelyn).
mujer(cynthia).
mujer(zendaya).

padre(jordy,zendaya).
madre(evelyn,zendaya).

padre(edwin,andres).
padre(edwin,david).
madre(cynthia,andres).
madre(cynthia,david).

padre(jaime,cynthia).
padre(jaime,evelyn).
padre(jaime,hebert).
madre(victoria,cynthia).
madre(victoria,evelyn).
madre(victoria,hebert).

padre(maximo,victoria).
padre(felix,jaime).
madre(maria,victoria).
madre(magdalena,jaime).

hermano(X,Y):- padre(M,X), padre(M,Y),madre(N,X),madre(N,Y),not(X==Y).

tio(X,Y):- hermano(X,A), madre(A,Y), hombre(X).
tio(X,Y):- hermano(X,A), padre(A,Y), hombre(X).
tia(X,Y):- hermano(X,A), padre(A,Y), mujer(X).
tia(X,Y):- hermano(X,A), madre(A,Y), mujer(X).

primos(X,Y):- tio(A,X), padre(B,Y), hermano(A,B),not(X==Y).
primos(X,Y):- tia(A,X), padre(B,Y), hermano(A,B),not(X==Y).
primos(X,Y):- tio(A,X), madre(B,Y), hermano(A,B),not(X==Y).
primos(X,Y):- tia(A,X), madre(B,Y), hermano(A,B),not(X==Y).

abuelo(X,Y):- padre(X,K), padre(K,Y).
abuelo(X,Y):- padre(X,K), madre(K,Y).
abuela(X,Y):- madre(X,K), madre(K,Y).
abuela(X,Y):- madre(X,K), padre(K,Y).

nieto(X,Y):- padre(A,X), padre(Y,A).
nieto(X,Y):- madre(A,X), padre(Y,A).
nieto(X,Y):- padre(A,X), madre(Y,A).
nieto(X,Y):- madre(A,X), madre(Y,A).

