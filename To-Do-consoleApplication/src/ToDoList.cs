using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_consoleApplication.src
{
    internal class ToDoList
    {
        //make empty list for the future todo's
        List<ToDoItem> items = new List<ToDoItem>();
        //make a method to add new todo's
        public void addTodo(string name,string description)
        {
            ToDoItem item = new ToDoItem(name,description);
            items.Add(item);
        }
        //remove selectedTodo By Id(index)
        public void DeleteTodo(int index)
        {
            items.RemoveAt(index);
        }
        //markComplete todo
        public void MarkComplete(int index)
        {
            //looks in the list at the asked index
            //looks for the IsComplete property and sets it to true.
            items[index].IsComplete = true;
            //by default a list item is set to false.
        }
        public void DisplayList()
        {
            //\n = newline
            //\t = Tab (extra space)
            Console.WriteLine("To-Do List:\n");
            Console.WriteLine("Index\tStatus\t\t\tName\t\t\tDescription");
            //looks at the windowWith and draws a line from start to end.
            string line = new string('-', Console.WindowWidth);
            Console.WriteLine(line);

            for (int i = 0; i < items.Count; i++)
            {
                string statusItem = items[i].IsComplete ? "Completed" : "Not Completed";
                Console.WriteLine($"{i + 1}\t{statusItem}\t\t{items[i].Name}\t\t\t{items[i].Description}");
            }

            Console.WriteLine("");

        }
    }
}
