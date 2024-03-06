using System.Globalization;

namespace Atividade_Interfarce.entities
{
    public class Pagamento
    {
        public double PagamentoBasico { get; private set; }
        public double Taxa { get; private set; }
        public Pagamento(double pagamentoBasico, double taxa)
        {   
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }
        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }
        public override string ToString()
        {
            return $"Pagamento básico: {PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)} \nTaxa: {Taxa} \nPagamento Total: {PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture)} ";
        }
    }
}