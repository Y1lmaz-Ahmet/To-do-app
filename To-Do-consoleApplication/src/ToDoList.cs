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
        public void addTodo(string name,string description,bool IsComplete)
        {
            ToDoItem item = new ToDoItem(name,description,IsComplete);
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
        }
    }
}
