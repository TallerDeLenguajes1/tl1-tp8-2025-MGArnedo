public class Tarea
{
    private int TareaID;
    private string Descripcion;
    private int Duracion;
    private static int contadorID = 1000;

    public int TareaID
    {
        get => tareaID;
        private set => tareaID = value; ////Numérico autoincremental comenzando en 1000
    }
    public string Descripcion
    {
        get => descripcion;
        set => descripcion = value;
    }
    public int Duracion
    {
        get => duracion;
        set
        {
            if (value < 10 || value > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(Duracion), "La duración debe estar entre 10 y 100.");
            }
            duracion = value;
        }
    } // Validar que esté entre 10 y 100
    // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
class Program
    {

    }

    
}

