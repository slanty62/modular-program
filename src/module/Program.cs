using System;
using System.Linq;

class ModularProgramming
{
    // 7.4. Максимум трех выражений
    static double MaxOfExpressions(double a, double b)
    {
        double x = Math.Pow(Math.Cos(a + b), 2);
        double y = Math.Sin(a + b);
        double z = Math.Pow(a, b);

        return Math.Max(x, Math.Max(y, z));
    }

    // 7.9. Подсчет повторений числа в массиве
    static int CountOccurrences(int[] arr, int n)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num == n) count++;
        }
        return count;
    }

    // 7.10. Подсчет символов в строке
    static int CountCharOccurrences(string text, char targetChar)
    {
        int count = 0;
        foreach (char c in text)
        {
            if (c == targetChar) count++;
        }
        return count;
    }

    // 7.11. Максимальный элемент и количество максимумов
    static (int maxValue, int count) FindMaxAndCount(int[] arr)
    {
        if (arr.Length == 0) return (0, 0);

        int maxValue = arr.Max();
        int count = arr.Count(x => x == maxValue);

        return (maxValue, count);
    }

    // 7.16. Замена элементов диагонали матрицы на нули
    static int[,] ZeroDiagonal(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            matrix[i, i] = 0;
        }
        return matrix;
    }

    // 7.17. Замена отрицательных чисел на единицы
    static int[,] ReplaceNegativesWithOnes(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] < 0) matrix[i, j] = 1;
            }
        }
        return matrix;
    }

    // 7.18. Сумма минимальных элементов по строкам
    static int SumOfRowMinimals(int[,] matrix)
    {
        int totalSum = 0;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            int min = matrix[i, 0];
            for (int j = 1; j < cols; j++)
            {
                if (matrix[i, j] < min) min = matrix[i, j];
            }
            totalSum += min;
        }
        return totalSum;
    }

    // 7.21. Реверс строки
    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // 7.22. Добавление символов в начало строки
    static string AddPrefix(string s)
    {
        return "++++-----" + s;
    }

    // 7.23. Строка из повторяющихся символов
    static string RepeatChar(char symbol, int k)
    {
        return new string(symbol, k);
    }

    // 7.24. Суммирование первых n элементов массива
    static int SumFirstNElements(int[] arr, int n)
    {
        if (n > arr.Length) n = arr.Length;

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    // Вспомогательные методы для вывода
    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }

    // Главный метод
    static void Main()
    {
        Console.WriteLine("=== МОДУЛЬНОЕ ПРОГРАММИРОВАНИЕ ===\n");

        // 7.4. Максимум трех выражений
        Console.WriteLine("7.4. Максимум трех выражений:");
        double a = 1.5, b = 2.0;
        double result74 = MaxOfExpressions(a, b);
        Console.WriteLine($"При a={a}, b={b}: максимум = {result74:F3}\n");

        // 7.9. Подсчет повторений числа в массиве
        Console.WriteLine("7.9. Подсчет повторений числа в массиве:");
        int[] array79 = { 2, 5, 3, 2, 7, 2, 8, 2, 1, 9 };
        int number = 2;
        int result79 = CountOccurrences(array79, number);
        Console.Write("Массив: "); PrintArray(array79);
        Console.WriteLine($"Число {number} встречается {result79} раз(а)\n");

        // 7.10. Подсчет символов в строке
        Console.WriteLine("7.10. Подсчет символов в строке:");
        string text = "программирование - это интересно";
        char targetChar = 'р';
        int result710 = CountCharOccurrences(text, targetChar);
        Console.WriteLine($"Текст: '{text}'");
        Console.WriteLine($"Символ '{targetChar}' встречается {result710} раз(а)\n");

        // 7.11. Максимальный элемент и количество максимумов
        Console.WriteLine("7.11. Максимальный элемент и количество максимумов:");
        int[] array711 = { 3, 7, 2, 7, 5, 7, 1, 7 };
        var (maxVal, count) = FindMaxAndCount(array711);
        Console.Write("Массив: "); PrintArray(array711);
        Console.WriteLine($"Максимальный элемент: {maxVal}, встречается {count} раз(а)\n");

        // 7.16. Замена элементов диагонали матрицы на нули
        Console.WriteLine("7.16. Замена элементов диагонали матрицы на нули:");
        int[,] matrix716 = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix716);
        ZeroDiagonal(matrix716);
        Console.WriteLine("После замены диагонали:");
        PrintMatrix(matrix716);
        Console.WriteLine();

        // 7.17. Замена отрицательных чисел на единицы
        Console.WriteLine("7.17. Замена отрицательных чисел на единицы:");
        int[,] matrix717 = {
            {1, -2, 3},
            {-4, 5, -6},
            {7, -8, 9}
        };
        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix717);
        ReplaceNegativesWithOnes(matrix717);
        Console.WriteLine("После замены отрицательных:");
        PrintMatrix(matrix717);
        Console.WriteLine();

        // 7.18. Сумма минимальных элементов по строкам
        Console.WriteLine("7.18. Сумма минимальных элементов по строкам:");
        int[,] matrix718 = {
            {3, 1, 4},
            {2, 5, 1},
            {7, 3, 2}
        };
        Console.WriteLine("Матрица:");
        PrintMatrix(matrix718);
        int result718 = SumOfRowMinimals(matrix718);
        Console.WriteLine($"Сумма минимальных элементов по строкам: {result718}\n");

        // 7.21. Реверс строки
        Console.WriteLine("7.21. Реверс строки:");
        string text721 = "программирование";
        string result721 = ReverseString(text721);
        Console.WriteLine($"Исходная строка: {text721}");
        Console.WriteLine($"Перевернутая строка: {result721}\n");

        // 7.22. Добавление символов в начало строки
        Console.WriteLine("7.22. Добавление символов в начало строки:");
        string text722 = "пример строки";
        string result722 = AddPrefix(text722);
        Console.WriteLine($"Результат: {result722}\n");

        // 7.23. Строка из повторяющихся символов
        Console.WriteLine("7.23. Строка из повторяющихся символов:");
        char symbol = '*';
        int k = 5;
        string result723 = RepeatChar(symbol, k);
        Console.WriteLine($"Строка из {k} символов '{symbol}': {result723}\n");

        // 7.24. Суммирование первых n элементов массива
        Console.WriteLine("7.24. Суммирование первых n элементов массива:");
        int[] array724 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int n = 4;
        int result724 = SumFirstNElements(array724, n);
        Console.Write("Массив: "); PrintArray(array724);
        Console.WriteLine($"Сумма первых {n} элементов: {result724}\n");

        Console.WriteLine("Все задачи выполнены!");
    }
}