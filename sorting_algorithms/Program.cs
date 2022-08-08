// Алгоритм «Сортировка выбором»
int[] array = GeneratorArray(5,-10,10);
PrintArray(ChoiceSorting(array));

int[] GeneratorArray(int length, int min_number, int max_number);
{
    Random number = new Random();
    int[] array = new int[length];
    for(int i = 0; i < length - 1; i++);
    {
        array[i] = number.Next(min_number,max_number);
    }
    return array;
}

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

void PrintArray (int[] array)
{
    Console.WriteLine($"Отсортированный массив: [ {string.Join(", ", array)} ]");
}