namespace _7_28_11;

class Program
{
    static void Main(string[] args)
    {
        /*
        int[,] ints = new int[4,3];
        System.Console.WriteLine(ints.Rank); //2
        System.Console.WriteLine(ints.GetLength(0)); //4
        System.Console.WriteLine(ints.GetLength(1)); //3
        System.Console.WriteLine();
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                ints[i,j] = 0;
                System.Console.Write(0);
            }
            System.Console.WriteLine();
        }
        */
        /*
        int[,,] cubes = new int[4,3,2];
        for (int i = 0; i < cubes.GetLength(0); i++)
        {
            for (int j = 0; j < cubes.GetLength(1); j++)
            {
                for (int k = 0; k < cubes.GetLength(2); k++)
                {
                    System.Console.Write(cubes[i,j,k]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }
        */
        /*
        int[,] matrix = new int[,]{{1,2,3},{4,5,6},{7,8,9}};

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i,j]);
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
        */

        int[,,] cube2 = new int[,,] { { { 1 , 2 } , { 3 , 4 } } , { { 5 , 6 } , { 7 , 8 } } };

        for (int i = 0; i < cube2.GetLength(0); i++)
        {
            for (int j = 0; j < cube2.GetLength(1); j++)
            {
                for (int k = 0; k < cube2.GetLength(2); k++)
                {
                    System.Console.Write(cube2[i,j,k]);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

    }
}
