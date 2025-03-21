namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            Console.WriteLine($"Initial Capacity: {list.Capacity}");
            Console.WriteLine($"Initial Count: {list.Count}");

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Console.WriteLine($"Count after adding elements: {list.Count}");
            Console.WriteLine($"Capacity after resize: {list.Capacity}");

            Console.WriteLine($"Element at index 2: {list[2]}");
            list[2] = 10;
            Console.WriteLine($"New element at index 2: {list[2]}");

            list.Remove(10);
            Console.WriteLine($"Count after removing element: {list.Count}");

            list.RemoveAt(1);
            Console.WriteLine($"Count after removing at index 1: {list.Count}");

            int[] arr = { 100, 200, 300 };
            CustomList<int> arrayList = new CustomList<int>(arr);
            Console.WriteLine($"Array constructor count: {arrayList.Count}");

            Console.WriteLine("Elements in the list:");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
