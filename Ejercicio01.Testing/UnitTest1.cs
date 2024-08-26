using Ejercicio01.Entidades;

namespace Ejercicio01.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetVolumen_DebedarOK()
        {
            //arrange
            var esfera = new Esfera(1);
            double volumenCorrecto = 4.18879;

            //act
            double volumenActual = esfera.CalcularVolumen();

            //assert
            Assert.AreEqual(volumenCorrecto, volumenActual, 1e-5);

        }

        [TestMethod]
        public void GetArea_DebeDarOk()
        {
            var esfera = new Esfera(1);
            double areaCorrecto = 12.56637;

            double areaTotalActual = esfera.CalcularArea();

            Assert.AreEqual(areaCorrecto, areaTotalActual, 1e-5);
        }
    }
}