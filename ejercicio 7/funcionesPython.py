from tokenize import Double

def suma(a, b):
  print("suma " +str(a + b))
def resta(a, b):
  print("resta " +str(a - b))
def multiplicasion(a, b):
  print("multiplicasion " +str(a * b))
def division(a, b):
  print("division " +str(a / b))

def main():
    a = int(input("ingrese a "))
    b = int(input("ingrese b "))
    suma(a,b)
    resta(a,b)
    multiplicasion(a,b)
    division(a,b)
if __name__ == "__main__":
    main()