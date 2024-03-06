using Atividade_Interfarce.entities;
using Atividade_Interfarce.Service;

namespace Atividade 
{
    class Program 
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Dados do aluguel ");
            Console.Write("Modelo do Carro: ");
            String modelo = Console.ReadLine();
            Console.Write("Inicio do Aluguel (MM/dd/yyyy HH:mm) ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Final do Aluguel (MM/dd/yyyy HH:mm) ");
            DateTime final = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Preço por hora: ");
            double hora = double.Parse(Console.ReadLine());
            Console.Write("Preço por dia: "); 
            double dia = double.Parse(Console.ReadLine());
            ServicoAluguel servicoAluguel = new ();
            Aluguel_de_Carros aluguel = new Aluguel_de_Carros(inicio, final, new Veiculo(modelo));

            servicoAluguel.Pagamento(aluguel);

            System.Console.WriteLine("Nota de Pagamento: ");
            Console.Write(aluguel.Nota);


        }
    }
}