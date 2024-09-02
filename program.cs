using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoList = new ToDoList();
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Gestor de Tareas");
                Console.WriteLine("1. Agregar tarea");
                Console.WriteLine("2. Listar tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.Write("Ingrese la descripción de la tarea: ");
                        string description = Console.ReadLine();
                        todoList.AddTask(description);
                        break;

                    case "2":
                        todoList.ListTasks();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        todoList.ListTasks();
                        Console.Write("Ingrese el número de la tarea a marcar como completada: ");
                        if (int.TryParse(Console.ReadLine(), out int completedIndex))
                        {
                            todoList.MarkTaskAsCompleted(completedIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "4":
                        todoList.ListTasks();
                        Console.Write("Ingrese el número de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex))
                        {
                            todoList.RemoveTask(removeIndex - 1);
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case "5":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
