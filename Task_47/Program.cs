double[,] fillMatrix(double[,] matrix){
    Random integer_num = new Random();
    Random float_num = new  Random();
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            matrix[i, j] = Math.Round(integer_num.Next(-10, 11) + float_num.NextDouble(), 2);;
        }
    }
    return matrix;
}

void printMatrix(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            Console.Write($"{matrix[i, j]}," + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
double[,] matrix = new double[rows, cols];

printMatrix(fillMatrix(matrix));