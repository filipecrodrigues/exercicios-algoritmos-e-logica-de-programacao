using System; //importa biblioteca system, funções básicas

/*Peça ao usuário 10 números e, para cada um, exiba se ele é par ou ímpar.*/

class Program // classe program
{
    static void Main() //Ponto de entrada do programa
    {
        Console.WriteLine("Digite 10 números para verificar se são pares ou impares");


        for (int i = 1; i < 11; i++)
        {

            Console.Write($"Digite o {i}° número: ");

            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é Par");

            }
            else
            {
                Console.WriteLine($"O número {numero} é Impar");
            }
        }

        Console.WriteLine("Programa finalizado");
    }
    

}
