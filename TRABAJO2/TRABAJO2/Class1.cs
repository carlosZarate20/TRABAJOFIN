using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO2
{
    public class Class1
    {
          public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Dividir(int a, int b)
          {
            try
            {
                return a/b;
            }
              catch(Exception e)
            {
                Console.WriteLine("ERROR");
                return 0;
              }
            
          }

        public int Multiplicar(int a, int b)
        {
            try
            {
                if (a == 0 || b == 0)
                    throw new Exception();
                return a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
                return 1;
            }

        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public bool Existe(int a)
        {
            int[] vector = new int[3];

            for (int i = 0; i < 3; i++)
            {
                vector[i] = i + 1;
            }

            for (int i = 0; i < 3; i++)
            {
                if (vector[i] == a)
                    return true;
            }
            return false;
        }

        public string Palabra()
        {
            string pa = "hola";
            return pa;
        }

        public List<int> RetornaLista()
        {
            List<int> lista = new List<int>();

            lista.Add(1);
            lista.Add(2);
            lista.Add(3);

            return lista;
        }

        public string RetornaUltimaLetra(List<string> lista)
        {
            string letra = lista[lista.Count - 1];

            return letra;
        }


        public string RetornarPimeraLetra(List<string> lista)
        {
            string letra = lista[0];
            return letra;
        }

        public int RetornaConteo(List<string> lista)
        {
            
            return lista.Count;
        }


        public int RetornaSumaTexto(List<int> lista)
        {
            int sum = 0;
            for (int i = 0; i < lista.Count() ;i++ )
            {
                sum = sum + lista[i];
            }
            
            return sum;
        }


        public int RetornaMultiplicacionTexto(List<int> lista)
        {
            int mul = 0;
            for (int i = 0; i < lista.Count(); i++)
            {
                mul = mul * lista[i];
            }

            return mul;
        }

        public int RetornaSumaPrimeroyUltimo(List<int> lista)
        {
            int suma = lista[0] + lista[lista.Count() - 1];

            return suma;
        }
    }
    
}
