using System;

namespace ToDoApp
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        // Constructor
        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        // Método para mostrar la tarea en formato legible
        public override string ToString()
        {
            return $"{(IsCompleted ? "[X]" : "[ ]")} {Description}";
        }
    }
}
