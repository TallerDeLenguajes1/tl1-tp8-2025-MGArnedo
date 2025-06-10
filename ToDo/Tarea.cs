namespace EspacioTarea 
{
    public class Tarea
    {
        public int TareaID { get; set; }
        public string Descripcion { get; set; }
        public int Duracion
        {
            get => duracion;
            set
            {
                if (value < 101 && value > 9)
                    Duracion = value;
                else
                    Console.WriteLine("Error: La duracion debe estar entre 10 y 100")
            }
        } // Validar que esté entre 10 y 100 
                                          // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario 
        
        private static int contadorID = 1000;

        public Tarea(string Descripcion, int Duracion)
        {
            this.TareaID = contadorID++;
            this.Descripcion = Descripcion;
            this.Duracion = Duracion;
         }
        

        


    }

}