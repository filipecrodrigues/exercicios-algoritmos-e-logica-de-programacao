//Solicite 5 números e informe quantos deles são positivos, negativos ou zero.

Console.WriteLine("Informe 5 números para validação!"); // Mensagem inicial para o usuário

for (int i = 1; i < 6; i++) // Laço que repete 5 vezes (de 1 a 5)
{
    Console.Write($"Digite o {i}° número: "); // Solicita o número correspondente
    string? input = Console.ReadLine(); // Lê o texto digitado (pode ser nulo)


    if (int.TryParse(input, out int numero)) // Tenta converter o texto para inteiro
    {
        if (numero < 0) // Verifica se o número é negativo
        {
            Console.WriteLine($"Número {numero} é negativo! ");  // Exibe que é negativo

        }
        else if (numero == 0) // Verifica se o número é igual a zero

        {
            Console.WriteLine("ZERO"); // Exibe que é zero
        }
        else // Caso contrário, o número é positivo
        {
            Console.WriteLine($"Número {numero} é positivo! ");  // Exibe que é positivo

        }
    }
    else // Se não for possível converter o texto para número
    {
        Console.WriteLine("Entrada invalida! "); // Exibe mensagem de erro
    }
}