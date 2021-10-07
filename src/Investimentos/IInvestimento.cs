namespace src.Investimentos
{
    public interface IInvestimento
    {
        decimal MontanteJurosSimples();
        decimal MontanteJurosCompostos();
        decimal GetTaxaJurosCompostosMensal();
    }
}