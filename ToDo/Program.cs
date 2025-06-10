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
            tareasPendientes.Add(new Tarea(descripcion,duracion));
        }
    }
}