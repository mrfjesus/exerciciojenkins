using Xunit;

namespace xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_BomDia()
        {
            DateTime dt = new DateTime(2023, 5, 11, 11, 0, 0);
            string resultadoesperado = "Bom dia MRJ";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("MRJ", dt));
        }
        [Fact]
        public void Test_BoaTarde()
        {
            DateTime dt = new DateTime(2023, 5, 11, 15, 0, 0);
            string resultadoesperado = "Boa tarde MRJ";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("MRJ", dt));
        }
        [Fact]
        public void Test_BoaNoite()
        {
            DateTime dt = new DateTime(2023, 5, 11, 22, 0, 0);
            string resultadoesperado = "Boa noite MRJ";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("MRJ", dt));
        }
    }
}