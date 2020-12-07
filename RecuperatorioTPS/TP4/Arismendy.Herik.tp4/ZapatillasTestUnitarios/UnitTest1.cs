using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Arismendy.Herik.tp4;

namespace ZapatillasTestUnitarios
{
    [TestClass]
    
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(MaximoBotinesExcepcion))]
        public void MaximoBotines_Test()
        {
            // arrange
            Botines botin1 = new Botines("Adidas", 10, 500, true);
            Botines botin2 = new Botines("Nike", 9, 300, false);
            Carrito carrito1 = new Carrito();
            //act
            carrito1 += botin1;
            carrito1 += botin2;
            //assert          
        }

        [TestMethod]
        [ExpectedException(typeof(SneakerRepetidoExcepcion))]
        public void SneakerRepetido_Test()
        {
            // arrange
            Sneakers sneaker1 = new Sneakers("Adidas", 10, 500, EProcedencia.Afganistan);
            Sneakers sneaker2 = new Sneakers("Nike", 9, 300, EProcedencia.Argentina);
            Sneakers sneaker3 = new Sneakers("Adidas", 10, 500, EProcedencia.Afganistan);
            Carrito carrito1 = new Carrito();
            //act
            carrito1 += sneaker1;
            carrito1 += sneaker2;
            carrito1 += sneaker3;
            //assert
        }

        [TestMethod]
        public void StringToEprocedencia_Test()
        {
            // arrange
            Sneakers sneaker1 = new Sneakers("Adidas", 10, 500, EProcedencia.Afganistan);
            Sneakers sneaker2 = new Sneakers("Nike", 9, 300, EProcedencia.Argentina);
            string procedencia = "EstadosUnidos";
            EProcedencia auxProcedencia;
            //act
            auxProcedencia = Sneakers.StringToProcedencia(procedencia);
            //assert
            Assert.AreEqual(auxProcedencia, EProcedencia.EstadosUnidos);
        }

        [TestMethod]
        public void ClienteTicket_Test()
        {
            // arrange
            Cliente cliente1 = new Cliente("HERIK", 95889316, "salta233", 500, EMetodoPago.Tarjeta);
            bool ticketGenerado;
            //act
            ticketGenerado = cliente1.Facturar();
            //assert
            Assert.IsTrue(ticketGenerado);
        }

        [TestMethod]
        public void ClienteToXml_Test()
        {
            // arrange
            Cliente cliente1 = new Cliente("prueba", 89316, "salta233", 500, EMetodoPago.MercadoPago);
            bool xmlGenerado;
            //act
            xmlGenerado = cliente1.Xml();
            //assert
            Assert.IsTrue(xmlGenerado);
        }

        [TestMethod]
        public void StringToMetodoPago_Test()
        {
            // arrange
            Cliente cliente1 = new Cliente("prueba", 89316, "salta233", 500, EMetodoPago.MercadoPago);
            string metodoPago = "Tarjeta Debito/Credito";
            EMetodoPago auxMetodoPago; 
            //act
            auxMetodoPago = cliente1.StringaMetodoPago(metodoPago);
            //assert
            Assert.AreEqual(auxMetodoPago,EMetodoPago.Tarjeta);
        }
    }
}
