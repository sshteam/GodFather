namespace KingCulator.Sort
{
    class Choose : ISorter
    {
        public void Sort(double[] doubleArray)
        {
            int min, temp;
            int length = doubleArray.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (doubleArray[j] < doubleArray[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = (int) doubleArray[i];
                    doubleArray[i] = doubleArray[min];
                    doubleArray[min] = temp;
                }
            }
        }
    }
}
