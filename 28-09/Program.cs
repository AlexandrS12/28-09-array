// See https://aka.ms/new-console-template for more information

// task 1

class Programm
{
    static void Main()
    {
        try
        {
            int[] array = null;
            array = new int[10];
            Random rnd = new();
            Console.WriteLine("Array before deleteing: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 6);
                Console.Write("{0,4}", array[i]);
            }
            Console.WriteLine();


            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    array[j] = array[i];
                    j++;
                }
            }


            for (int i = j; i < array.Length; i++)
            {
                array[i] = -1;
            }

            Console.WriteLine("After deleting: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0,4}", array[i]);// not WriteLine bcz 
            }
            Console.WriteLine();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
