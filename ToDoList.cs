using System;
using System.Collections.Generic;

namespace ToDoApp
{
    public class ToDoList
    {
        private List<Task> tasks;

        // Constructor
        public ToDoList()
        {
            tasks = new List<Task>();
        }

        // Agregar una nueva tarea
        public void AddTask(string description)
        {
            var task = new Task(description);
            tasks.Add(task);
        }

        // Listar todas las tareas
        public void ListTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No hay tareas en la lista.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        // Marcar una tarea como completada
        public void MarkTaskAsCompleted(int index)
        {
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Índice de tarea inválido.");
                return;
            }

            tasks[index].IsCompleted = true;
        }

        // Eliminar una tarea
        public void RemoveTask(int index)
        {
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Índice de tarea inválido.");
                return;
            }

            tasks.RemoveAt(index);
        }
    }
}
