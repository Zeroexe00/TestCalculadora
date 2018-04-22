using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioTDD;

namespace ParcialSimpleTest
{
    [TestClass]
    public class UnitTest1
    { 
        [TestMethod]
        public void SumaDeValores()
        {
            
            int resultado = CalculadoraSimple.Suma(2, 2);

            Assert.AreEqual(4,resultado);

        }
        [TestMethod]
        public void SumaDeCaracteres()
        {
           

            int resultado = CalculadoraSimple.Suma("1","2");
            Assert.AreEqual(3, resultado);
        }
        [TestMethod]
        public void SumaDeValoresConCero()
        {
            int resultado = CalculadoraSimple.Suma("","");
            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void Resta()
        {
            int resultado = CalculadoraSimple.Resta(9, 5);

            Assert.AreEqual(4, resultado);
        }
        [TestMethod]
        public void RestaConCero()
        {
            int resultado = CalculadoraSimple.Resta("7","");
            Assert.AreEqual(7, resultado);

        }
        [TestMethod]
        public void Multi()
        {
            int res = CalculadoraSimple.Multi(1, 2);
            Assert.AreEqual(2, res);

        }
        public void MultiConCero()
        {
            int res = CalculadoraSimple.Multi("","5");
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void RaizCuadrada()
        {
            double res = CalculadoraSimple.RaizCuadrada(4);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Potencia()
        {
            double res = CalculadoraSimple.Potencia(7, 2);
            Assert.AreEqual(49, res);
        }
        [TestMethod]
        public void Division()
        {
            int res = CalculadoraSimple.Division(2, 1);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void DivisionNumEntero()
        {
            double res = CalculadoraSimple.Division(5, 2);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Residuo()
        {
            double res = CalculadoraSimple.Residuo(5, 2);
            Assert.AreEqual(1, res);
        }
    }
}
