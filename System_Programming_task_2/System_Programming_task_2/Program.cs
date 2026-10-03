using System;
using System.IO;
using System.Threading;

namespace System_Programming_task_2
{
    internal class Program
    {
        static bool isRunning1 = false;
        static bool isRunning2 = false;
        static bool isRunning3 = false;

        static Thread? thread1 = null;
        static Thread? thread2 = null;
        static Thread? thread3 = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Go To Files 1");
                Console.WriteLine("Exit 0");
                Console.Write("Secim: ");
                string? choice = Console.ReadLine();

                if (choice == "0")
                {
                    break;
                }
                else if (choice == "1")
                {
                    Console.WriteLine();
                    Console.WriteLine("file 1");
                    Console.WriteLine("file 2");
                    Console.WriteLine("file 3");
                    Console.WriteLine();
                    Console.WriteLine("write no of file start");
                    Console.WriteLine("s-1 for stop");
                    Console.WriteLine("s-2 for stop");
                    Console.WriteLine("stopall");
                    Console.WriteLine("exit");
                    Console.WriteLine();

                    while (true)
                    {
                        string? command = Console.ReadLine();

                        if (command == "1")
                        {
                            if (!isRunning1)
                            {
                                isRunning1 = true;
                                thread1 = new Thread(() =>
                                {
                                    int count = 1;
                                    while (isRunning1)
                                    {
                                        File.AppendAllText("file1.txt", "File 1: " + count + "\n");
                                        Console.WriteLine("Writing to file 1...");
                                        count++;
                                        Thread.Sleep(500);
                                    }
                                });
                                thread1.IsBackground = true;
                                thread1.Start();
                            }
                            else
                            {
                                Console.WriteLine("file 1 artiq isleyir");
                            }
                        }
                        else if (command == "2")
                        {
                            if (!isRunning2)
                            {
                                isRunning2 = true;
                                thread2 = new Thread(() =>
                                {
                                    int count = 1;
                                    while (isRunning2)
                                    {
                                        File.AppendAllText("file2.txt", "File 2: " + count + "\n");
                                        Console.WriteLine("Writing to file 2...");
                                        count++;
                                        Thread.Sleep(500);
                                    }
                                });
                                thread2.IsBackground = true;
                                thread2.Start();
                            }
                            else
                            {
                                Console.WriteLine("file 2 artiq isleyir");
                            }
                        }
                        else if (command == "3")
                        {
                            if (!isRunning3)
                            {
                                isRunning3 = true;
                                thread3 = new Thread(() =>
                                {
                                    int count = 1;
                                    while (isRunning3)
                                    {
                                        File.AppendAllText("file3.txt", "File 3: " + count + "\n");
                                        Console.WriteLine("Writing to file 3...");
                                        count++;
                                        Thread.Sleep(500);
                                    }
                                });
                                thread3.IsBackground = true;
                                thread3.Start();
                            }
                            else
                            {
                                Console.WriteLine("file 3 artiq isleyir");
                            }
                        }
                        else if (command == "s-1")
                        {
                            if (isRunning1)
                            {
                                isRunning1 = false;
                                Console.WriteLine("file 1 dayandirildi");
                            }
                        }
                        else if (command == "s-2")
                        {
                            if (isRunning2)
                            {
                                isRunning2 = false;
                                Console.WriteLine("file 2 dayandirildi");
                            }
                        }
                        else if (command == "s-3")
                        {
                            if (isRunning3)
                            {
                                isRunning3 = false;
                                Console.WriteLine("file 3 dayandirildi");
                            }
                        }
                        else if (command == "stopall")
                        {
                            isRunning1 = false;
                            isRunning2 = false;
                            isRunning3 = false;
                            Console.WriteLine("butun fayllar dayandirildi");
                        }
                        else if (command == "exit")
                        {
                            isRunning1 = false;
                            isRunning2 = false;
                            isRunning3 = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
