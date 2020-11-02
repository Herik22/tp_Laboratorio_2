using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;
using EntidadesAbstractas;
using Excepciones;

namespace TestUnitariosTp3
 {                     /* Test Unitarios:
                        a. Generar al menos dos métodos de test unitario distintos que validen que se lancen
                        correctamente excepciones producidas por nuestro código.
                        b. Generar al menos uno que valide se haya instanciado un atributo del tipo colección en alguna
                        de las clases dadas. */

    [TestClass]
    
    public class UniversidadTest
    {
        
        [TestMethod]
        //  verifica la iguald de entreun alumno y la clase que ve.
        public void IgualdadAlumno_OK()
        {
            //Arrange
            Alumno auxA = new Alumno(1,"Prueba1","p1","95889316",Persona.ENacionalidad.Extranjero,Universidad.EClases.Laboratorio,Alumno.EEstadoCuenta.AlDia);
            Universidad.EClases auxC = Universidad.EClases.Laboratorio;
            //Act
            bool rta = auxA == auxC;

            //Assert
            Assert.IsTrue(rta);
        }

        [TestMethod]
        //  Verifica que se lance la excepcion indicada al ingresar mal la nacionalidad
        public void VerifNacionalidad_Falla()
        {

            try
            {
                //Arrange
                Alumno a1 = new Alumno(2, "prueba2", "p2", "958893168", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
            }
            //Act
            catch (NacionalidadInvalidaException e)
            {
                //Assert
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }

        }

        [TestMethod]
        //  Verifica que se lance la excepcion indicada al ingresar mal el formato dedni.
        public void VerifValidadDni_Falla() 
        {

            try
            {
                //Arrange
                Alumno a1 = new Alumno(2, "prueba2", "p2", "958893tres", Persona.ENacionalidad.Extranjero, Universidad.EClases.SPD);
            }
                //Act
            catch (DniInvalidoException e)
            {
                //Assert
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }

        }

        [TestMethod]
        //  Verifica que se incialicen todas las listas de la Universidad
        public void VerifListasInstanciadas_Falla() 
        {

            //Arrange / Act
            Universidad auxUni = new Universidad();


            //Assert
            Assert.IsNotNull(auxUni.Alumnos);
            Assert.IsNotNull(auxUni.Instructores);
            Assert.IsNotNull(auxUni.Jornadas);


        }
    }

    
}
