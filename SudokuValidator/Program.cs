using System;

namespace SudokuValidator
{
    public class Solution
    {
        // Converte a string em uma matriz 9x9 e valida o Sudoku
        public static string Validar(string entrada)
        {
            int[,] grid = new int[9, 9];

            for (int i = 0; i < 81; i++)
            {
                grid[i / 9, i % 9] = (int)char.GetNumericValue(entrada[i]);
            }

            for (int linha = 0; linha < 9; linha++)
            {
                int[] valoresLinha = new int[9];
                for (int coluna = 0; coluna < 9; coluna++)
                    valoresLinha[coluna] = grid[linha, coluna];

                if (!ConjuntoValidado(valoresLinha))
                    return "Sudoku incorreto";
            }

            for (int coluna = 0; coluna < 9; coluna++)
            {
                int[] valoresColuna = new int[9];
                for (int linha = 0; linha < 9; linha++)
                    valoresColuna[linha] = grid[linha, coluna];

                if (!ConjuntoValidado(valoresColuna))
                    return "Sudoku incorreto";
            }

            for (int blocoLinha = 0; blocoLinha < 9; blocoLinha += 3)
            {
                for (int blocoColuna = 0; blocoColuna < 9; blocoColuna += 3)
                {
                    int[] bloco = new int[9];
                    int index = 0;

                    for (int linha = blocoLinha; linha < blocoLinha + 3; linha++)
                    {
                        for (int coluna = blocoColuna; coluna < blocoColuna + 3; coluna++)
                        {
                            bloco[index++] = grid[linha, coluna];
                        }
                    }

                    if (!ConjuntoValidado(bloco))
                        return "Sudoku incorreto";
                }
            }

            return "Sudoku correto";
        }

        private static bool ConjuntoValidado(int[] numeros)
        {
            bool[] vistos = new bool[10];

            foreach (int numero in numeros)
            {
                if (numero < 1 || numero > 9 || vistos[numero])
                    return false;

                vistos[numero] = true;
            }

            return true;
        }

       public static void Main()
{
    Console.WriteLine("Digite os 81 números do Sudoku (sem espaços):");
    string entrada = Console.ReadLine() ?? string.Empty;

    if (entrada.Length != 81)
    {
        Console.WriteLine("Entrada inválida! Digite exatamente 81 números.");
        return;
    }

    string resultado = Validar(entrada);
    Console.WriteLine(resultado);
}
    }
}
