using System;
using EspacioTarea;
class Program
{
    static void Main()
    {
        List<Tarea> tareasPendientes = new List<Tarea>();
        List<Tarea> tareasRealizadas = new List<Tarea>();
        CrearListaAleatoria(tareasPendientes);
        int opcion;
        do
        {
            Console.WriteLine("===MENU PRINCIPAL===\nPresione 1 para mover tareas pendientes a realizadas\nPresione 2 para buscar tareas pendientes por descripcion\nPresione 3 para mostar la lista de tareas pendientes y realizadas\nPresione 0 para salir del programa");
            Console.WriteLine("Elija un opcion: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MoverTareasDeUnaListaAOtra(tareasPendientes, tareasRealizadas);
                    break;
                case 2:
                    BuscarTareasPorDescripcionYMostrarlas(tareasPendientes);
                    break;
                case 3:
                    MostrarLista(tareasPendientes, "Lista tareas PENDIENTES");
                    MostrarLista(tareasRealizadas, "Lista tareas REALIZADAS");
                    break;
                case 0:
                    Console.WriteLine("===FIN DEL PROGRAMA===");
                    break;
                default:
                    Console.WriteLine("Entrada invalida: Elija un numero entre 1 y 3");
                    break;
            }
        } while (opcion != 0);
    }

        
        //3. Desarrolle una interfaz para mover las tareas pendientes a realizadas. La lista de tareas realizadas (por ejemplo, List<Tarea> tareasRealizadas) inicialmente estará vacía. 
        

        //4. Desarrolle una función para buscar tareas pendientes por descripción y mostrarla por consola. 
        
        
        //5. Mostrar un listado de todas las tareas (pendientes y realizadas) 
        
        //6. Diseña un menú principal que permita al usuario acceder a cada una de las funcionalidades descritas. La interacción debe ser intuitiva (ej. "Presione 1 para...", "Ingrese el ID de la tarea:", etc.). 
    

    static void CrearListaAleatoria(List<Tarea> Lista1)
    {
        Random random = new Random();

        int numeroDeTareas = 5;

        for (int i = 0; i < numeroDeTareas; i++)
        {
            string descripcion = $"Tarea {i + 1}";
            int duracion = random.Next(10, 101);
            Lista1.Add(new Tarea(descripcion, duracion));
        }
    }
    static void MoverTareasDeUnaListaAOtra(List<Tarea> Lista1, List<Tarea> Lista2)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese el ID de la tarea pendiente para moverla a realizada: ");
                int buscarId = int.Parse(Console.ReadLine());
                Tarea tarea = Lista1.Find(f => f.TareaID == buscarId);
                if (tarea != null)
                {
                    Lista1.Remove(tarea);
                    Lista2.Add(tarea);
                }
                break;
            }
            catch
            {
                Console.WriteLine("Entrada invalida");
            }
        }
    }
    static void BuscarTareasPorDescripcionYMostrarlas(List<Tarea> Lista1)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Ingrese la descripcion de las tareas a buscar: ");
                string buscarDescripcion = Console.ReadLine().ToLower().Trim();
                List<Tarea> tareas = Lista1.FindAll(f => f.Descripcion.ToLower().Contains(buscarDescripcion));
                if (tareas.Count > 0)
                {
                    MostrarLista(tareas, "Lista de tareas pendientes que coinciden con la descripcion");
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
    }
    static void MostrarLista(List<Tarea> Lista1, string titulo)
    {
        Console.WriteLine($"---{titulo}---");
        foreach (var tarea in Lista1)
        {
            Console.WriteLine($"ID: {tarea.TareaID}\nDescripcion: {tarea.Descripcion}\nDuracion: {tarea.Duracion}");
        }
    }
}

