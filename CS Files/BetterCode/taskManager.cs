// Task Maker:

// I made this program for fun, found it on a random folder on my computer.
// Allows you to make a task, view tasks, clear tasks etc.

using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool running = true;

            Console.WriteLine("=== Task Manager ===");
            Console.WriteLine("A simple console-based to-do list.\n");

            while (running)
            {
                DisplayMenu();
                Console.Write("Select an option: ");
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        ClearTasks();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Exiting program...");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Add a new task");
            Console.WriteLine("2 - View all tasks");
            Console.WriteLine("3 - Remove a task");
            Console.WriteLine("4 - Clear all tasks");
            Console.WriteLine("5 - Exit");
        }

        static void AddTask()
        {
            Console.Write("Enter a new task: ");
            string task = Console.ReadLine().Trim();

            if (string.IsNullOrEmpty(task))
            {
                Console.WriteLine("You can't add an empty task.");
                return;
            }

            tasks.Add(task);
            Console.WriteLine("Task added.");
        }

        static void ViewTasks()
        {
            Console.WriteLine("\nYour Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks yet.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to remove.");
                return;
            }

            ViewTasks();
            Console.Write("Enter the number of the task to remove: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int index))
            {
                if (index >= 1 && index <= tasks.Count)
                {
                    string removed = tasks[index - 1];
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine($"Removed: {removed}");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        static void ClearTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to clear.");
                return;
            }

            Console.Write("Are you sure you want to clear all tasks? (y/n): ");
            string confirm = Console.ReadLine().Trim().ToLower();

            if (confirm == "y")
            {
                tasks.Clear();
                Console.WriteLine("All tasks cleared.");
            }
            else
            {
                Console.WriteLine("Cancelled.");
            }
        }
    }
}
