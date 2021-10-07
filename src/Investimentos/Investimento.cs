using System;

namespace src.Investimentos
{
    public class Investimento : IInvestimento
    {
        public decimal Montante { get; private set; }
        public decimal JurosAnual { get; private set; }
        public int PeriodoInvestimentoAnos { get; private set; }

        public Investimento(decimal montante, decimal jurosAnual, int periodoInvestimentoAnos)
        {
            Montante = montante;
            JurosAnual = jurosAnual;
            PeriodoInvestimentoAnos = periodoInvestimentoAnos;
        }

        public Investimento(decimal jurosAnual)
        {
            JurosAnual = jurosAnual;
        }

        public decimal MontanteJurosSimples()
        {
            var acrescimo = Montante * JurosAnual * PeriodoInvestimentoAnos;
            var montanteFinal = Montante + acrescimo;

            return montanteFinal;
        }

        public decimal MontanteJurosCompostos()
        {
            var juros = (decimal)Math.Pow(1 + (double)JurosAnual, PeriodoInvestimentoAnos);
            var montanteFinal = Montante * juros;

            return montanteFinal;
        }

        public decimal GetTaxaJurosCompostosMensal()
        {
            var jurosMensal = (decimal)Math.Pow(1 + (double)JurosAnual, 1.0/12.0) - 1;
            return jurosMensal;
        }
    }
}