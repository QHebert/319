using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Calculadora
    {
        public string opera(string d)
        {
            string subs = "", car;
            string aux = "";
            string operaciones = "";
            int largo = d.Length;
            for (int i = 0; i < largo; i++)
            {
                car = d.Substring(i, 1);
                if (car.Equals("/") || car.Equals("*") || car.Equals("-") || car.Equals("+"))
                {
                    aux = aux + subs + ";";
                    subs = "";
                    operaciones = operaciones + car + ";";
                }
                else
                {
                    subs = subs + car;
                }
            }
            aux += subs;
            return Calcula(aux, operaciones);
            
        }

        private string Calcula(string aux, string operaciones)
        {
            double res = 0, siguiente;
            string[] nro, ope;
            ope = operaciones.Split(';');
            nro = aux.Split(';');
            res = Double.Parse(nro[0]);
            for (int i = 0; i < ope.Length - 1; i++)
            {
                siguiente = Double.Parse(nro[i + 1]);
                switch (ope[i])
                {
                    case "+":
                        res = res + siguiente;
                        break;
                    case "-":
                        res = res - siguiente;
                        break;
                    case "*":
                        res = res * siguiente;
                        break;
                    case "/":
                        if (siguiente != 0)
                        {
                            res = res / siguiente;
                        }
                        break;
                    default:
                        break;
                }
            }
            return res.ToString();
        }
    }
}
