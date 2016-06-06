using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using TRABAJO2;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumaIgual()//VALOR IGUAL NUMERO
        {
            Class1 clase = new Class1();
            const int sum1 = 3;
            const int sum2 = 2;
            const int esperado = 5;

            var actual = clase.Suma(sum1, sum2);

            Assert.AreEqual(esperado, actual);
        }
        [TestMethod]
        public void TestRestaIgual()//VALOR DIFERENTE NUMERO
        {
            Class1 clase = new Class1();
            const int res1 = 6, res2 = 2;
            const int esperado = 5;

            var actual = clase.Resta(res1, res2);

            Assert.AreNotEqual(esperado, actual);
        }

        [TestMethod]
        public void TestBoolExiste()//VALOR BOOLEANO
        {
            Class1 clase = new Class1();
            const int numero = 2;

            Assert.IsTrue(clase.Existe(numero), "Es verdadero");
        }


        [TestMethod]
        public void TestString()//IGUAL TEXTO
        {
            Class1 clase = new Class1();
            string p = "hola";
            Assert.AreEqual(p, clase.Palabra());
        }
        [TestMethod]
        public void TestStringMoIgual()//NO IGUAL TEXTO
        {
            Class1 clase = new Class1();
            string p = "hola mundo";
            Assert.AreNotEqual(p, clase.Palabra());
        }

        [TestMethod]
        //VALORES NULOS
        public void TestISNOTNULL()
        {
            Class1 clase = new Class1();

            Assert.IsNotNull(clase.RetornaLista());
        }

        [TestMethod]
        public void TestArreglo1()// COMPARA SI LOS ARRAYS SON IGUALES
        {
            Class1 clase = new Class1();
            var vec = new List<int>();
            vec.Add(1);
            vec.Add(2);
            vec.Add(3);

            CollectionAssert.AreEqual(clase.RetornaLista(), vec);
        }

        [TestMethod]
        public void TestArreglo2()// COMPARA SI SON DIFERENTES
        {
            Class1 clase = new Class1();
            var vec = new List<int>();

            CollectionAssert.AreNotEqual(clase.RetornaLista(), vec);
        }

        [TestMethod]
        public void TestCompararCarrosIguales()//OBJETOS IGUALES?
        {

            Carro car1 = new Carro();
            car1.Marca = "Audi";
            car1.placa = 123;

            Carro car2 = new Carro();
            car2.Marca = "Audi";
            car2.placa = 123;

            Assert.AreNotEqual(car1, car2);

        }

        [TestMethod]
        public void TestCompararCarrosNoIguales()//OBJETOS NO IGUALES
        {
            Carro car1 = new Carro();
            car1.Marca = "Audi";
            car1.placa = 123;

            Carro car2 = new Carro();
            car2.Marca = "Toyota";
            car2.placa = 123;

            Assert.AreNotEqual(car1, car2);

        }

        /////FUENTE EXTERNA

        [TestMethod]
        //retorna ultima letra
        public void TestUltimaLetra()
        {
            Class1 clase = new Class1();
            var texto = new StreamReader("archivo1.txt");

            string letrasString = texto.ToString();
            List<string> LTexto = letrasString.Select(c => c.ToString()).ToList();

            Assert.AreEqual(LTexto[LTexto.Count - 1], clase.RetornaUltimaLetra(LTexto));
        }

        [TestMethod]
        //retorna primera letra
        public void TestPrimeraLetra()
        {
            Class1 clase = new Class1();
            var texto = new StreamReader("archivo2.txt");
            string letrasString = texto.ReadToEnd();

            List<string> LTexto = letrasString.Select(c => c.ToString()).ToList();

            Assert.AreEqual(LTexto[0], clase.RetornarPimeraLetra(LTexto));
        }

        [TestMethod]
        public void TestConteo()//misma longitud
        {
            Class1 clase = new Class1();
            var texto = new StreamReader("archivo3.txt");

            string letrasString = texto.ToString();
            List<string> LTexto = letrasString.Select(c => c.ToString()).ToList();


            Assert.AreEqual(LTexto.Count, clase.RetornaConteo(LTexto));
        }


        [TestMethod]
        public void TestSumaTexto()//suma
        {
            Class1 clase = new Class1();
            var leer = new StreamReader("archivo4.txt");
            string num = leer.ReadToEnd();

            var numeros = num.Split(',').Select(Int32.Parse).ToList();

            int sum = 0;
            for (int i = 0; i < numeros.Count(); i++)
            {
                sum = sum + numeros[i];
            }

            Assert.AreEqual(sum, clase.RetornaSumaTexto(numeros));
        }

        [TestMethod]
        public void TestMultplicacionTexto()//multiplicacion
        {
            Class1 clase = new Class1();
            var leer = new StreamReader("archivo5.txt");
            string num = leer.ReadToEnd();

            var numeros = num.Split(',').Select(Int32.Parse).ToList();

            int mul = 0;
            for (int i = 0; i < numeros.Count(); i++)
            {
                mul = mul * numeros[i];
            }

            Assert.AreEqual(mul, clase.RetornaMultiplicacionTexto(numeros));
        }

        [TestMethod]
        public void TestSumPrimeroUltimoTexto()//suma entre el primero y el ultimo
        {
            Class1 clase = new Class1();
            var leer = new StreamReader("archivo6.txt");
            string num = leer.ReadToEnd();

            var numeros = num.Split(',').Select(Int32.Parse).ToList();

            int suma = numeros[0] + numeros[numeros.Count() - 1];

            Assert.AreEqual(suma, clase.RetornaSumaPrimeroyUltimo(numeros));
        }


        [TestMethod]
        public void TestDividirEntreCero()//ERROR DIVIDIR ENTRE 0
        {
            Class1 clase = new Class1();
            int a = 5, b = 0;
            int e = 0;

            Assert.AreEqual(e, clase.Dividir(a, b));
        }

        [TestMethod]
        public void TestMuliplicarporCero()//MULTIPLICAR POR 0
        {
            Class1 clase = new Class1();
            int a = 7, b = 0;
            int e = 1;

            Assert.AreEqual(e, clase.Multiplicar(a,b));
        }
    }
}
