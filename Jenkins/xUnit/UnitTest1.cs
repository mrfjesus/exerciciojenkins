using Xunit;

namespace xUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test_BomDia()
        {
            DateTime dt = new DateTime(2023, 5, 11, 0, 0, 0);
            string resultadoesperado = "Bom dia Mario Jesus";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Mario Jeus", dt));

        }
        [Fact]
        public void Test_BoaTarde()
        {
            DateTime dt = new DateTime(2023, 5, 11, 0, 0, 0);
            string resultadoesperado = "Boa tarde Mario Jesus";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Mario Jeus", dt));

        }
        [Fact]
        public void Test_BoaNoite()
        {
            DateTime dt = new DateTime(2023, 5, 11, 0, 0, 0);
            string resultadoesperado = "Boa noite Mario Jesus";
            Assert.Equal(resultadoesperado, Lib.Saudacao.Cumprimentar("Mario Jeus", dt));

        }
    }
}