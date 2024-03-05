using System.Globalization;
using Atividade_Interfarce.entities;

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
            Aluguel_de_Carros aluguel = new Aluguel_de_Carros(inicio, final, new Veiculo(modelo));
            System.Console.WriteLine("Nota de Pagamento: ");
            Console.Write(aluguel.Nota);

        }
    }
}