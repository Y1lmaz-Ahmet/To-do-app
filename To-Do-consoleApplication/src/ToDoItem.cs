using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_consoleApplication.src
{
    internal class ToDoItem
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public ToDoItem(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
