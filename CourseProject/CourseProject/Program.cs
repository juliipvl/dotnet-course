using System;
using System.Threading;

namespace CourseProject
{
    class Person
    {
        public string Name;
        public int Age;
    }

    internal class Program
    {
        static object lock1 = new object();
        static object lock2 = new object();

        static object fixedLock1 = new object();
        static object fixedLock2 = new object();

        static Person person = new Person { Name = "Julia", Age = 22 };

        static void Main(string[] args)
        {
            Console.WriteLine("DEADLOCK HAPPENS");

            Thread thread1 = new Thread(() =>
            {
                lock (lock1)
                {
                    Thread.Sleep(1000);
                    lock (lock2)
                    {
                        Console.WriteLine("Thread 1 (deadlock)");
                    }
                }
            });

            Thread thread2 = new Thread(() =>
            {
                lock (lock2)
                {
                    Thread.Sleep(1000);
                    lock (lock1)
                    {
                        Console.WriteLine("Thread 2 (deadlock)");
                    }
                }
            });

            thread1.Start();
            thread2.Start();
            thread1.Join(3000);
            thread2.Join(3000);

            Console.WriteLine("\nFIXED DEADLOCK");

            Thread thread3 = new Thread(() =>
            {
                lock (fixedLock1)
                {
                    Thread.Sleep(1000);
                    lock (fixedLock2)
                    {
                        Console.WriteLine("Thread 3 (fixed)");
                    }
                }
            });

            Thread thread4 = new Thread(() =>
            {
                lock (fixedLock1)
                {
                    Thread.Sleep(1000);
                    lock (fixedLock2)
                    {
                        Console.WriteLine("Thread 4 (fixed)");
                    }
                }
            });

            thread3.Start();
            thread4.Start();
            thread3.Join();
            thread4.Join();

            Console.WriteLine("\nRACE CONDITION HAPPENS");

            for (int i = 0; i < 50; i++)
            {
                Thread writePerson = new Thread(() =>
                {
                    person.Name = "Yulia";
                    Thread.Sleep(30);

                    person.Age = 20;
                });

                Thread readPerson = new Thread(() =>
                {
                    string name = person.Name;
                    int age = person.Age;

                    if (name == "Yulia" && age == 22)
                    {
                        Console.WriteLine($"Race Condition: {name} {age}");
                    }
                });

                writePerson.Start();
                readPerson.Start();
                writePerson.Join();
                readPerson.Join();
            }

            Console.WriteLine("\nFIXED RACE CONDITION");

            object personLock = new object();
            bool bugDetected = false;

            for (int i = 0; i < 50; i++)
            {
                lock (personLock)
                {
                    person = new Person { Name = "Julia", Age = 22 };
                }

                Thread writer = new Thread(() =>
                {
                    lock (personLock)
                    {
                        person.Name = "Yulia";
                        Thread.Sleep(30);
                        person.Age = 20;
                    }
                });

                Thread reader = new Thread(() =>
                {
                    string name;
                    int age;

                    lock (personLock)
                    {
                        name = person.Name;
                        age = person.Age;
                    }

                    if (name == "Yulia" && age == 22)
                    {
                        Console.WriteLine($"❗ STILL BUG (shouldn't happen): {name} {age}");
                        bugDetected = true;
                    }
                });

                writer.Start();
                reader.Start();
                writer.Join();
                reader.Join();
            }

            if (!bugDetected)
            {
                Console.WriteLine("No race condition detected");
            }
        }
    }
}