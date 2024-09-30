// See https://aka.ms/new-console-template for more information

using System;
//3.Дан двумерный массив размерностью N x M, заполненный
//случайными числами из диапазона от 0 до 100. Выполнить
//циклический сдвиг массива на заданное количество столбцов.
//Направление сдвига задаёт пользователь.
class Programm
{
    static void Main()
    {
        try
        {
            int N = 5;
            int M = 5;

            int[,] array;
            array = new int[N, M];
            Random rnd = new();

            Console.WriteLine("Array: ");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    array[i, j] = rnd.Next(0, 101);
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Enter rows slide:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Chose 1 - right , 2 - left:");
            int direction = int.Parse(Console.ReadLine());



            if (direction == 1)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int temp = array[i, 0];
                        for (int k = 0; k < M - 1; k++)
                        {
                            array[i, k] = array[i, k + 1];
                        }
                        array[i, M - 1] = temp;
                    }
                }
            }



            else if (direction == 2)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int temp = array[i, M - 1];
                        for (int k = M - 1; k > 0; k--)
                        {
                            array[i, k] = array[i, k - 1];
                        }
                        array[i, 0] = temp;
                    }
                }
            }


            Console.WriteLine("Result: ");


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0,4}", array[i, j]);
                }
                Console.WriteLine();
            }

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
