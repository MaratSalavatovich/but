public static class Infrastructure
{
    /// <summary>
    /// Метод создания и заполнение массива
    /// </summary>
    /// <param name="size">Размер нового массива </param>
    /// <param name="min">Нижняя граница заполнения </param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив </returns>
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
               .Select(item => Random.Shared.Next(min, max))
               .ToArray();
    }



    /// <summary>
    /// Вывод массива в консоль
    /// </summary>
    /// <param name="array"></param>
    public static void Print(int[] array)
    {
        Console.WriteLine($"[{String.Join(',', array)}]");
    }
}