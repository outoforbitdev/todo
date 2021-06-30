using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class ToDoItem: Entity
    {
        public int Priority { get; set; }
        public bool Urgent { get; set; }
        public bool Completed { get; set; }
        public ToDoList List { get; set; }

        public ToDoItem()
        {
            Name = "";
            Environment = "";
            Priority = 1;
            Urgent = false;
            Completed = false;
        }

        public ToDoItem(string name, string environment) : this()
        {
            Name = name;
            Environment = environment;
        }
    }
}
