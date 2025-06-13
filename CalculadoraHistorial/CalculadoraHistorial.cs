namespace EspacioCalculadora
{
    public enum TipoOperacion
    { 
        Suma, 
        Resta, 
        Multiplicacion, 
        Division, 
        Limpiar  // Representa la acción de borrar el resultado actual o el historial 
    }
    public class Operacion
    {
        private double resultadoAnterior { get; set; } // Almacena el resultado previo al cálculo actual 
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior 

        public TipoOperacion Tipo => operacion;

        private TipoOperacion operacion { get; set; }// El tipo de operación realizada 
        public double Resultado
        {
            get
            {
                switch (operacion)
                {
                    case TipoOperacion.Suma:
                        return resultadoAnterior + nuevoValor;
                    case TipoOperacion.Resta:
                        return resultadoAnterior - nuevoValor;
                    case TipoOperacion.Multiplicacion:
                        return resultadoAnterior * nuevoValor;
                    case TipoOperacion.Division:
                        if (nuevoValor != 0)
                        {
                            return resultadoAnterior / nuevoValor;
                        }
                        else
                        {
                            throw new DivideByZeroException("No se puede dividir en cero");
                        }
                    case TipoOperacion.Limpiar:
                        return 0;
                    default:
                        Console.WriteLine("Operacion invalida");
                        return 0;
                }
            }
            /* Lógica para calcular o devolver el resultado */
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación 
        public double NuevoValor {
            get
            {
                return nuevoValor;
            }

        }
        // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
        // ... 
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
        }
    } 
    public class Calculadora
        {
            private double numero;
            private List<Operacion> historial = new List<Operacion>();
            public List<Operacion> Historial => historial;

            public Calculadora(double valorInicial = 0)
        {
            numero = valorInicial;
        }
        public void Sumar(double termino)
        {
            historial.Add(new Operacion(numero, termino, TipoOperacion.Suma));
            numero += termino;
                
        }
        public void Restar(double termino)
        {
            historial.Add(new Operacion(numero, termino, TipoOperacion.Resta));
            numero -= termino;
        }
        public void Multiplicar(double termino)
        {
            historial.Add(new Operacion(numero, termino, TipoOperacion.Multiplicacion));
            numero *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                historial.Add(new Operacion(numero, termino, TipoOperacion.Division));
                numero /= termino;
            }
            else
            {
                throw new DivideByZeroException("No se puede dividir en cero");
            }
            }
            public double Resultado
            {
                get => numero;
            }
            public void Limpiar()
            {
                historial.Add(new Operacion(numero, 0, TipoOperacion.Limpiar));
                numero = 0;
            }
        }
}

