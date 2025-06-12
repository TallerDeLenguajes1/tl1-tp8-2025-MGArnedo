using System;
using EspacioTarea;
class Program
{
    static void Main()
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();
        Random random = new Random();

        int numeroDeTareas = 5;

        for (int i = 0; i < numeroDeTareas; i++)
        {
            string descripcion = $"Tarea {i + 1}";
            int duracion = random.Next(10, 101);
            tareasPendientes.Add(new Tarea(descripcion, duracion));
        }
        //3. Desarrolle una interfaz para mover las tareas pendientes a realizadas. La lista de tareas realizadas (por ejemplo, List<Tarea> tareasRealizadas) inicialmente estará vacía. 
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese el ID de la tarea pendiente para moverla a realizada: ");
                int buscarId = int.Parse(Console.ReadLine());
                Tarea tarea = tareasPendientes.Find(f => f.TareaID == buscarId);
                if (tarea != null)
                {
                    tareasPendientes.Remove(tarea);
                    tareasRealizadas.Add(tarea);
                }
                break;
            }
            catch
            {
                Console.WriteLine("Entrada invalida");
            }
        }
        
        //4. Desarrolle una función para buscar tareas pendientes por descripción y mostrarla por consola. 
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese la descripcion de las tareas a buscar: ");
                string buscarDescripcion = Console.ReadLine().ToLower().Trim();
                List<Tarea> tareas = tareasPendientes.FindAll(f => f.Descripcion.ToLower().Contains(buscarDescripcion));
                if (tareas.Count > 0)
                {
                    MostrarTareas(tareas, "Lista de tareas pendientes que coinciden parcialmente con la descripcion");
                }
                else
                {
                    Console.WriteLine("No se encontraron tareas que coincidan");
                }
                break;
            }
            catch
            {
                Console.WriteLine("Entrada invalida");
            }
        }
        
        //5. Mostrar un listado de todas las tareas (pendientes y realizadas) 
        MostrarTareas(tareasPendientes, "Lista tareas PENDIENTES");
        MostrarTareas(tareasRealizadas, "Lista tareas REALIZADAS");
        //6. Diseña un menú principal que permita al usuario acceder a cada una de las funcionalidades descritas. La interacción debe ser intuitiva (ej. "Presione 1 para...", "Ingrese el ID de la tarea:", etc.). 
    }
    static void MostrarTareas(List<Tarea> Lista1, string titulo)
    {
        Console.WriteLine($"---{titulo}---");
        foreach (var tarea in Lista1)
        {
            Console.WriteLine($"ID: {tarea.TareaID}\nDescripcion: {tarea.Descripcion}\nDuracion: {tarea.Duracion}");
        }
    }
}

