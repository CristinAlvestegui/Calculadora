using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        public double num1;
        public double num2;
        public ModelCalculadora()
        {
              num1 = 0;
              num2 = 0;
            
        }//Fim do construtor

        public double Somar(double num1, double num2)
        {
            return num1 + num2;
        }//Fim do método Somar

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }//Fim do método Multiplicar

        public double Subtrair(double num1, double num2)
        {
            return num1 - num2;
        }//Fim do método Subtrair

        public double Dividir(double num1, double num2)
        {
            if (num1 <= 0)
            {
                return -1;
            }
            return num1 / num2;
        }//Fim do método Dividir
        
        public double Potenciacao (double bas, double expoente)
        {
            if (expoente == 0)
            {
                return 1;
            }else if (expoente ==1)
            {
                return bas;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }
        }//Fim do método Potenciacão

        public double Raiz(double num1)
        {
            if (num1 < 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }
        }//Fim do método Raiz

        

        


    }//fim da classe
}//Fim do projeto
