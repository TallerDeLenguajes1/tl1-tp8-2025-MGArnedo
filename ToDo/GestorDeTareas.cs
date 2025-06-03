class GestoreTareas
{
    List<Tareas> TareasPendientes;
    //completadas
    contadorId;
}
public GestorDeTareas() {
    TareasCompletadas = new List<Tareas>();
    tareasPendientes = [];
    contadorId = 1;
}
public void AgregarTarea(string descripcion)
{
    Tarea nuevaTarea = new Tarea(contadorId++, descripcion)
    TareasPendientes.Add(nuevaTarea);
}