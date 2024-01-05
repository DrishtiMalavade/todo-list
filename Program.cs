using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\u001b[33m===== To-Do List =====\u001b[0m");
            Console.WriteLine("\u001b[32m1. Add Task\u001b[0m");
            Console.WriteLine("\u001b[32m2. View Tasks\u001b[0m");
            Console.WriteLine("\u001b[32m3. Mark Task as Completed\u001b[0m");
            Console.WriteLine("\u001b[32m4. Motivation\u001b[0m");
            Console.WriteLine("\u001b[32m5. Exit\u001b[0m");

            Console.Write("Enter your choice (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    MarkAsCompleted();
                    break;
                case "4":
                    ShowMotivation();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddTask()
    {
        Console.Write("Enter a new task: ");
        string newTask = Console.ReadLine();
        tasks.Add(newTask);
        Console.WriteLine("Task added successfully!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks found.");
        }
        else
        {
            Console.WriteLine("Tasks:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void MarkAsCompleted()
    {
        ViewTasks();

        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks to mark as completed.");
            return;
        }

        Console.Write("Enter the task number to mark as completed: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            Console.WriteLine($"Task '{tasks[taskNumber - 1]}' marked as completed!");
            tasks.RemoveAt(taskNumber - 1);
        }
        else
        {
            Console.WriteLine("Invalid task number. Please try again.");
        }
    }

    static void ShowMotivation()
    {
        string[] motivationalMessages = {
            "Believe you can and you're halfway there.",
            "The time is now.",
            "aim for the moon and you'll reach the stars",
            "Don't watch the clock; do what it does. Keep going.",
            "The future belongs to those who believe in the beauty of their dreams.",
            "Your limitation—it's only your imagination.",
            "Strive for progress, not perfection."
        };

        Random random = new Random();
        int index = random.Next(motivationalMessages.Length);

        Console.WriteLine("\u001b[34m\n********************************\n\u001b[0m");
        Console.WriteLine(motivationalMessages[index]);
        Console.WriteLine("\u001b[34m\n********************************\n\u001b[0m");
    }
}