using System.Runtime.InteropServices;

namespace CourseProject
{
    internal class Program
    {
        /*
        class Cat
        {
            public string Name;
        } 
        */

        static void Main(string[] args)
        {
            /*
            // Value Type
            Console.WriteLine("VALUE TYPE");
            int firstVal = 5;
            int secondVal = firstVal;
            Console.WriteLine($"First value is: {firstVal}");
            Console.WriteLine($"Second value equals {secondVal} when we initialize it by first value");

            secondVal = 15;

            Console.WriteLine("\n---After changing the value in the second variable---");
            Console.WriteLine($"Second value will change: {secondVal}, but first is still {firstVal}");

            // Reference Type
            Console.WriteLine("\nREFERENCE TYPE");

            Cat cat1 = new Cat() { Name = "Sam" };
            Console.WriteLine($"Name of first cat: {cat1.Name}");

            Cat cat2 = cat1;
            Console.WriteLine($"Second cat will have address of first cat: {cat2.Name}");

            cat2.Name = "Jenny";

            Console.WriteLine("\n---After changing the value in the second cat---");
            Console.WriteLine($"Second cat will change name: {cat2.Name}");
            Console.WriteLine($"Both cats point to the same address, so the name of the first one will also change: {cat1.Name}");
            */

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
