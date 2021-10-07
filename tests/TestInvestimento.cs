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
        [InlineData(0, 0.1, 10, 0)]
        public void TestMontanteJurosSimples(decimal montante, decimal juros, int periodo, decimal resultado)
        {
            IInvestimento investimento = new Investimento(montante: montante, jurosAnual: juros, periodoInvestimentoAnos: periodo);

            Assert.Equal(resultado, investimento.MontanteJurosSimples());
        }

        [Theory]
        [InlineData(1, 12, 1, 13)]
        [InlineData(1, 12, 2, 169)]
        [InlineData(1.5, 0.1, 10, 3.89)]
        [InlineData(0, 0.1, 10, 0)]
        public void TestMontanteJurosCompostos(decimal montante, decimal juros, int periodo, decimal resultado)
        {
            IInvestimento investimento = new Investimento(montante: montante, jurosAnual: juros, periodoInvestimentoAnos: periodo);

            Assert.Equal(resultado, investimento.MontanteJurosCompostos(), 2);
        }

        [Theory]
        [InlineData(0.1, 0.007974)]
        [InlineData(0.15, 0.011715)]
        [InlineData(1, 0.059463)]
        public void TestGetTaxaJurosCompostosMensal(decimal taxaJurosAnual, decimal resultado)
        {
            IInvestimento investimento = new Investimento(jurosAnual: taxaJurosAnual);

            Assert.Equal(resultado, investimento.GetTaxaJurosCompostosMensal(), 4);
        }

        [Fact]
        public void TestComparar()
        {
            var juros = 0.1m;
            var periodo = 10;
            IInvestimento investimentoSuperior = new Investimento(montante: 2, jurosAnual: juros, periodoInvestimentoAnos: periodo);
            IInvestimento investimentoInferior = new Investimento(montante: 1, jurosAnual: juros, periodoInvestimentoAnos: periodo);

            Assert.Same(investimentoSuperior, Investimento.Comparar(investimentoSuperior, investimentoInferior));
        }
    }
}
