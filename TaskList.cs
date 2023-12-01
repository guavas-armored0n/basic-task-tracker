// TaskList.cs
using System;
using System.Collections.Generic;

public class TaskList
{
    private List<Task> tasks;

    public TaskList()
    {
        tasks = new List<Task>();
    }

    public void AddTask(string description)
    {
        tasks.Add(new Task { Description = description, IsCompleted = false });
        Console.WriteLine("Task added to the list.");
    }

    public void DisplayTasks()
    {
        Console.WriteLine("\nTask List:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks in the list.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. [{(tasks[i].IsCompleted ? 'X' : ' ')}] {tasks[i].Description}");
            }
        }
    }

    public void MarkTaskComplete(int index)
    {
        if (index >= 0 && index < tasks.Count)
        {
            tasks[index].IsCompleted = true;
            Console.WriteLine($"Task '{tasks[index].Description}' marked as completed.");
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }
}
