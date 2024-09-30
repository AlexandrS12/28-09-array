// See https://aka.ms/new-console-template for more information

using System;
//Заполнить квадратную матрицу размером N x N по спирали (N –
//нечётное число). Число 1 ставится в центр матрицы, а затем массив
//заполняется по спирали против часовой стрелки значениями по
//возрастанию. 
class Programm
{
    static void Main()
    {
        try
        {
            int N = 5;
            int[,] array;

            array = new int[N, N];

            int value = 1;
            int row = N / 2, col = N / 2;
            array[row, col] = value++;

            int basi = 1;
            int direction = 0;
            while (value <= N * N)
            {
                for (int i = 0; i < basi; i++)
                {
                    if (value > N * N)
                    {
                        break;
                    }


                    switch (direction)
                    {
                        case 0: row--; break; // вверх
                        case 1: col--; break; // влево
                        case 2: row++; break; // вниз
                        case 3: col++; break; // вправо
                    }

                    array[row, col] = value++;
                }

                direction++;
                if (direction == 4)
                {
                    direction = 0;

                }
                if (direction % 2 == 0)
                {
                    basi++;
                }

            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
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
