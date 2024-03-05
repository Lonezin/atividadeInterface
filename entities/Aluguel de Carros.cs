namespace Atividade_Interfarce.entities
{
    public class Aluguel_de_Carros
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Modelo { get; set; }
        public Pagamento Nota { get; set; }

        public Aluguel_de_Carros(DateTime inicio, DateTime final, Veiculo modelo)
        {
            Inicio = inicio;
            Final = final;
            Modelo = modelo;
            Nota = null; 
        }
    }
}