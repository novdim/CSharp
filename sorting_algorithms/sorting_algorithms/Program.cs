int[] array = GeneratorArray(5, -10, 10);
int[] array1 = GeneratorArray(5, -10, 10);
int[] array2 = GeneratorArray(5, -10, 10);
Console.WriteLine("Сортировка выбором");
PrintArray(ChoiceSorting(array));
Console.WriteLine();
Console.WriteLine("Сортировка пузырьком");
PrintArray(BubbleSorting(array1));
Console.WriteLine();
Console.WriteLine("Быстрая сортировка");
Console.WriteLine("Начальный массив: [" + string.Join(", ", array2) + "]");
QuickSort(array2, 0, array2.Length - 1);
PrintArray(array2);
Console.WriteLine();

int[] GeneratorArray(int length, int min_number, int max_number)
{
    Random number = new Random();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = number.Next(min_number, max_number);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"Отсортированный массив: [{string.Join(", ", array)}]");
}


// МЕТОДЫ Сортировки

// Сортировка выбором

int[] ChoiceSorting(int[] array)
{
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

    // Cортировка
    for (int i = 0; i < array.Length - 1; i++)
    {
        int MinIndex = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[MinIndex])
                MinIndex = j;
        }
        int temp = array[MinIndex];
        array[MinIndex] = array[i];
        array[i] = temp;
    }
    return array;
}

// Cортировка пузырьком

int[] BubbleSorting(int[] array)
{
    Console.WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");

    // Cортировка
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}


void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}
int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}