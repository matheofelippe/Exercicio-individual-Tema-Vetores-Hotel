using System;

namespace Exercicio_individual_Tema_Vetores_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospedes[] array = new Hospedes[10]; //Cria um array com 10 espaços(0 a 9)
            Console.Write("Quantos quartos estão alugados? "); // Pede ao usuario quantos quartos vão ser alugados
            int alugados = int.Parse(Console.ReadLine());

            for(int i = 1; i <= alugados; i++)
            {
                Console.WriteLine("Hospede #" + i + ";");
                Console.Write("Nome: "); // Nome do hospede
                string nome = Console.ReadLine();
                Console.Write("Email: "); // Email do hospede
                string email = Console.ReadLine();
                Console.Write("Quarto: "); // Quarto que o hospede vai alugar
                int quarto = int.Parse(Console.ReadLine());
                array[quarto] = new Hospedes(nome, email); // Cria um objeto hospede com nome, email e quarto alugado
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) // Passa por todo o array
            {
                if (array[i] != null) //Se o espaço do array for diferente de nulo, imprime no console os dados do hospeque e o quarto alugado
                {
                    Console.WriteLine(i + ": " + array[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
