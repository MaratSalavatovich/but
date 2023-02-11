public static class Sorting
{
    public static void SortType(int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for (int j = i; j < size; j++)
            {
                if (collection[j] < collection[pos]) pos = j;
            }
            int temp = collection[i];
            collection[i] = collection[pos];
            collection[pos] = temp;
        }
    }
}