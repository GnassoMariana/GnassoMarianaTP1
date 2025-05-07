using GnassoMarianaTP1.Entidades;
using System.ComponentModel.DataAnnotations;

namespace GnassoMarianaTP1.Testing
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CrearPriramide_Correcto()
        {
            var piramide = new PiramideCuadrada(6, 12);
            Assert.AreEqual(6, piramide.Lado);
            Assert.AreEqual(12, piramide.Altura);
        }

        [TestMethod]
        public void CalcularVolumen_Correcto()
        {
            var piramide = new PiramideCuadrada(6, 12);
            var resultado = (Math.Pow(6, 2) * 12) / 3;
            Assert.AreEqual(resultado, piramide.CalcularVolumen());
        }

        [TestMethod]
        public void CalcularArea_Correcto()
        {
            var piramide = new PiramideCuadrada(6, 12);
            var apotema = Math.Sqrt(Math.Pow(6 / 2.0, 2) + Math.Pow(12, 2));
            var resultado = Math.Pow(6, 2) + 2 * 6 * apotema;
            Assert.AreEqual(resultado, piramide.CalcularArea());
        }

        //[TestMethod]
        //public void CalcularApotema_Correcto()
        //{
        //    var piramide = new PiramideCuadrada(6, 12);
        //    var resultado = Math.Sqrt(Math.Pow(6 / 2.0, 2) + Math.Pow(12, 2));
        //    Assert.AreEqual(resultado, piramide.CalcularApotema());
            
        //}

        [TestMethod]
        public void InformarDatos_Correcto()
        {
            var piramide = new PiramideCuadrada(6, 12);
            var datos = piramide.InformarDatos();
            StringAssert.Contains(datos, "Volumen: 144");
            StringAssert.Contains(datos, "Area: 184,4318");
            StringAssert.Contains(datos, "Apotema: 12,3693");
        }

        [TestMethod]
        public void ToString_Correcto()
        {
            var piramide = new PiramideCuadrada(6, 12);
            var resultado = piramide.ToString();
            Assert.AreEqual("Piramide de lado: 6 y altura: 12", resultado);

        }

        [TestMethod]
        public void Validate_Errores()
        {
            var piramide = new PiramideCuadrada(0, -5);
            var context = new ValidationContext(piramide);
            var errores = new List<ValidationResult>();

            var esValido = Validator.TryValidateObject(piramide, context, errores, true);

            Assert.IsFalse(esValido);
            Assert.AreEqual(2, errores.Count);
        }
    }
}
