using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\t\nVERIFICAÇÃO DE IDADE PARA CARTEIRA DE MOTORISTA");

        // Solicita a idade do usuário
        Console.Write("Digite sua idade: ");
        string input = Console.ReadLine();

        // Valida a entrada
        if (int.TryParse(input, out int idade))
        {
            // Verifica se a idade é válida (entre 0 e 120 anos)
            if (idade < 0 || idade > 120)
            {
                Console.WriteLine("\t\nIdade inválida! Digite uma idade entre 0 e 120 anos.");
            }
            else
            {
                Console.WriteLine($"\t\nVocê tem {idade} anos.");

                // Verifica se pode tirar carteira
                if (idade >= 18)
                {
                    Console.WriteLine("\t\nPode tirar carteira de motorista!");

                    // Informações adicionais
                    if (idade >= 65)
                    {
                        Console.WriteLine("\t\n Atenção: A partir dos 65 anos, é necessário renovar a carteira a cada 3 anos.");
                    }
                }
                else
                {
                    int anosRestantes = 18 - idade;
                    Console.WriteLine("\t\nAinda não pode tirar carteira.");
                    Console.WriteLine($"\t\nFaltam {anosRestantes} ano(s) para atingir a idade mínima.");
                }
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite apenas números.");
        }

        // Pausa para ver o resultado no console
        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}