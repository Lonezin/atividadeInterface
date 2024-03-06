using Atividade_Interfarce.entities;

namespace Atividade_Interfarce.Service
{
    public class ServicoAluguel
    {
        public double PrecoPorDia { get; private set; }
        public double PrecoPorHora { get; private set; }
        private IServicoTaxa ServicoTaxa;

        public ServicoAluguel (double precoPorDia, double precoPorHora, IServicoTaxa servicoTaxa)
        {
            PrecoPorDia = precoPorDia;
            PrecoPorHora = precoPorHora;
            ServicoTaxa = servicoTaxa;
        }
        public void Pagamento(Aluguel_de_Carros aluguel_De_Carros) 
        {
            TimeSpan duracao = aluguel_De_Carros.Final.Subtract(aluguel_De_Carros.Inicio); 
            double pagamentoBasico = 0.0; 
            if (duracao.TotalHours <= 12.00)
            {
                pagamentoBasico = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }
            double tax = ServicoTaxa.Taxa(pagamentoBasico);
            aluguel_De_Carros.Nota = new Pagamento(pagamentoBasico, tax);
        }
    }
}