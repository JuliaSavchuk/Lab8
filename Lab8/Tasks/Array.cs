namespace Lab8
{
    public class Array : IOutput, IMath, ISort
    {
        public int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        //Task1
        public void Show()
        {
            Console.WriteLine("Elements of the array:");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }
        public void Show(string info)
        {
            Console.WriteLine($"Elements of the array: {info}");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }
        }

        //Task2
        public int Max()
        {
            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }
        public int Min()
        {
            int min = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] < min)
                {
                    min = elements[i];
                }
            }
            return min;
        }
        public float Avg()
        {
            int sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                sum += elements[i];
            }
            return (float)sum / elements.Length;
        }
        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == valueToSearch)
                {
                    return true;
                }
            }
            return false;
        }

        //Task3
        public void SortAsc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }
        public void SortDesc()
        {
            for (int i = 0; i < elements.Length - 1; i++)
            {
                for (int j = 0; j < elements.Length - 1 - i; j++)
                {
                    if (elements[j] < elements[j + 1])
                    {
                        int temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }
        public void SortByParam(bool isAsc)
        {
            if (isAsc)
            {
                SortAsc();
            }
            else
            {
                SortDesc();
            }
        }
    }
}
