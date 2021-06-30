using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Model
{
    public class ToDoList: Entity
    {
        public ToDoList(string name, string environment): this()
        {
            Name = name;
            Environment = environment;
        }
    }
}
