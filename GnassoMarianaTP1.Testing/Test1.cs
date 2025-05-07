using GnassoMarianaTP1.Entidades;

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


    }
}
