using static System.Console;

WriteLine("Введите количество элементов массива: ");

int n = Convert.ToInt32(ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    Write("Введите значение массива: ");
    array[i] = Convert.ToInt32(ReadLine());
}
WriteLine("Начальный массив: [" + string.Join(", ", array) + "]");
WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    WriteLine(i + "[" + string.Join(", ", array) + "]");
}