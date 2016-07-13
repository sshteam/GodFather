namespace KingCulator.Sort
{
    class QuickSort : ISorter
    {
                public void Sort(double[] doubleArray)
        {
            for (int i = 1; i < doubleArray.Length; i++)
            {
                double cur = doubleArray[i];
                int j = i;
                while (j > 0 && cur < doubleArray[j - 1])
                {
                    doubleArray[j] = doubleArray[j - 1];
                    j--;
                }
                doubleArray[j] = cur;
            }
        }

    }
}
