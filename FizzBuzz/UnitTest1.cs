using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Retorna_FizzBuzz_quando_passar_30()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz(30));
        }

        [TestMethod]
        public void Retorna_1_quando_passar_1()
        {
            Assert.AreEqual("1", FizzBuzz(1));
        }

        [TestMethod]
        public void Retorna_2_quando_passar_2()
        {
            Assert.AreEqual("2", FizzBuzz(2));
        }

        [TestMethod]
        public void Retorna_Fizz_quando_passar_3()
        {
            Assert.AreEqual("Fizz", FizzBuzz(3));
        }

        [TestMethod]
        public void Retorna_Buzz_quando_passar_5()
        {
            Assert.AreEqual("Buzz", FizzBuzz(5));
        }

        [TestMethod]
        public void Retorna_FizzBuzz_quando_passar_divisivel_por_3_e_5()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz(15));
        }


        [TestMethod]
        public void TesteListarTodos()
        {
            ListarTodos();
        }

        void ListarTodos()
        {
            var lista = Enumerable.Range(1, 100).Select(FizzBuzz).ToArray();

            foreach (var elemento in lista)
            {
                Console.Write(elemento + ", ");
            }
        }

        string FizzBuzz(int numero)
        {
            var result = string.Format("{0}{1}",
                numero % 3 == 0 ? "Fizz" : string.Empty,
                numero % 5 == 0 ? "Buzz" : string.Empty
                );

            return string.IsNullOrEmpty(result) ? numero.ToString() : result;
        }
    }
}
