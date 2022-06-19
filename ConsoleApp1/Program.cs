void exampleCSharp (int[,] grid)
{
    foreach (int row in grid)
    {
        return row;
    };
}

void Main()
{
    Console.WriteLine(
        exampleCSharp(
            new int[,] {
                {4, 2, 7, 1},
                {20, 70, 40, 90},
                {1, 2, 0, 0}
            }
        )
    );
}

Main();