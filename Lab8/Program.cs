namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 9, 2 };
            Array arrayObject = new Array(array);

            Console.WriteLine("=====Task 1=====");
            arrayObject.Show();
            arrayObject.Show("Information message");
            Console.WriteLine("\n===============");

            Console.WriteLine("\n=====Task 2=====");
            Console.WriteLine($"Max: {arrayObject.Max()}");
            Console.WriteLine($"Min: {arrayObject.Min()}");
            Console.WriteLine($"Average: {arrayObject.Avg()}");
            Console.WriteLine($"Is the number 3 in the array: {arrayObject.Search(3)}");
            Console.WriteLine($"Is the number 7 in the array: {arrayObject.Search(7)}");
            Console.WriteLine("\n===============");

            Console.WriteLine("\n=====Task 3=====");
            // Сортування залежно від параметру
            arrayObject.SortByParam(true); // сортування за зростанням
            arrayObject.Show("After sorting");
            arrayObject.SortByParam(false); // сортування за спаданням
            arrayObject.Show("After sorting");
            Console.WriteLine("\n===============");
        }
    }
}