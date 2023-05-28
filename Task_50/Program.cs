Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество колонок массива: ");
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] matrix = new int[rows, cols];

printMatrix(fillMatrix(matrix));

Console.Write("Введите число для поиска в матрице: ");
int numberToFind = Convert.ToInt32(Console.ReadLine());
int amount = 0;

findPositionOfNumber(numberToFind, matrix);

Console.Write("Введите номер строки для поиска числа: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки для поиска числа: ");
int column = Convert.ToInt32(Console.ReadLine());

// findNumberOnPositionFirstOption(row-1, column-1, matrix);
findNumberOnPositionSecondOption(row-1, column-1, matrix);

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

void findPositionOfNumber(int numberToFind, int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i+=1){
        for(int j = 0; j < matrix.GetLength(1); j+=1){
            if (matrix[i,j] == numberToFind){
                Console.WriteLine($"Число {numberToFind} было найдено в(о) {i+1}-й строке, в(о) {j+1}-м столбце");
                amount += 1;
            }
        }
    }
    if (amount == 0){
        Console.WriteLine($"Число {numberToFind} не было найдено в матрице");
    }
}


//Способ №1 с обработкой исключения "IndexOutOfRangeException":

// int findNumberOnPositionFirstOption(int row, int column, int[,] matrix){
//     try{
//         Console.WriteLine($"В(о) {row+1}-й строке и в(о) {column+1}-м столбце находится: {matrix[row, column]}(с помощью обработки исключения)");
//         return matrix[row, column];
//     }
//     catch (IndexOutOfRangeException e){
//         Console.WriteLine(e.Message);
//         throw new ArgumentOutOfRangeException("Index parameter was out of range");
//     }
// }

//Способ №2:

void findNumberOnPositionSecondOption(int row, int column, int[,] matrix){
    if ((row >= matrix.GetLength(0) || row < 0) && (column > 0 && column < matrix.GetLength(1))){
        Console.WriteLine("Error: row index was out of range"); 
    }
    else if ((column >= matrix.GetLength(1) || column < 0) && (row > 0 && row < matrix.GetLength(0))){
        Console.WriteLine("Error: column index was out of range"); 
    }
    else if ((row >= matrix.GetLength(0) || row < 0) && (column < 0 || column >= matrix.GetLength(1))){
        Console.WriteLine("Error: column and row index was out of range"); 
    }
    else {
        Console.WriteLine($"В(о) {row+1}-й строке и в(о) {column+1}-м столбце находится: {matrix[row, column]}"); 
    }
}
