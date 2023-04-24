using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_consoleApplication.src;

namespace To_Do_consoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList todoList = new ToDoList();

            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Mark complete");
                Console.WriteLine("4. Display list");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter task name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter task description: ");
                        string description = Console.ReadLine();
                        todoList.addTodo(name, description);
                        break;
                    case "2":
                        Console.Write("Enter item number to remove: ");
                        int index = int.Parse(Console.ReadLine()) - 1;
                        todoList.DeleteTodo(index);
                        break;
                    case "3":
                        Console.Write("Enter item number to mark complete: ");
                        index = int.Parse(Console.ReadLine()) - 1;
                        todoList.MarkComplete(index);
                        break;
                    case "4":
                        todoList.DisplayList();
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }
    }
}
