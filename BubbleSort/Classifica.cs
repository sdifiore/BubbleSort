namespace BubbleSort
{
    public static class Classifica
    {

        public static void Ascende(int dimensao, double[] sortArray)
        {
            for (int i = dimensao - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = calice;
                    }
                }
            }
        }

        public static void Descende(int dimensao, double[] sortArray)
        {
            for (int i = dimensao - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sortArray[j] < sortArray[j + 1])
                    {
                        var calice = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = calice;
                    }
                }
            }
        }
    }
}