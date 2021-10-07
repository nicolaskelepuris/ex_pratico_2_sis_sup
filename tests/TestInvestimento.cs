using src.Investimentos;
using Xunit;

namespace tests
{
  public class TestInvestimento
    {
        [Theory]
        [InlineData(1, 12, 1, 13)]
        [InlineData(1, 12, 10, 121)]
        [InlineData(100, 0.1, 1, 110)]
        [InlineData(1.5, 0.1, 10, 3)]
        public void TestMontanteJurosSimples(decimal montante, decimal juros, int periodo,  decimal resultado)
        {
            IInvestimento investimento = new Investimento(montante: montante, jurosAnual: juros, periodoInvestimentoAnos: periodo);

            Assert.Equal(resultado, investimento.MontanteJurosSimples());
        }
    }
}
