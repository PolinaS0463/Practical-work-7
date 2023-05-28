Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[rows, cols];

int[,] fillMatrix(int[,] matrix){
    Random num = new Random();
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            matrix[i, j] = num.Next(-10, 11);
        }
    }
    return matrix;
}

void printMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            Console.Write($"{matrix[i, j]}," + "\t");
        }
        Console.WriteLine();
    }
}

void findMeanInColumns(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(1); i+=1){
        double sum = 0;
        double mean = 0;
        int count = 0;
        for(int j = 0; j < matrix.GetLength(0); j+=1){
            sum += matrix[j, i];
            count += 1;
            if (count == matrix.GetLength(0)){
                mean = Math.Round(sum/matrix.GetLength(0), 2);
                Console.WriteLine($"Среднее арифметическое чисел в(о) {i+1}-м столбце составляет {mean}");
            }
        }
    }
}

printMatrix(fillMatrix(matrix));
findMeanInColumns(matrix);