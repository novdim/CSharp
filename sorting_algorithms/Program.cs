// Алгоритм «Сортировка выбором»
int[] array = {3,6,-2,0,5};

PrintArray(ChoiceSorting(array));

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