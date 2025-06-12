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
        private double resultadoAnterior; // Almacena el resultado previo al cálculo actual 
        private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior 
        private TipoOperacion operacion;// El tipo de operación realizada 
        public double Resultado
        {
            
            /* Lógica para calcular o devolver el resultado */
        }
        // Propiedad pública para acceder al nuevo valor utilizado en la operación 
        public double NuevoValor {
            get { ...}
        }
        // Constructor u otros métodos necesarios para inicializar y gestionar la operación 
        // ... 
        public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion, double Resultado)
        {
            this.resultadoAnterior = resultadoAnterior;
            this.nuevoValor = nuevoValor;
            this.operacion = operacion;
            this.Resultado = Resultado;
        }
    } 
    public class Calculadora
        {
            private double numero;
            public Calculadora(double valorInicial = 0)
            {
                numero = valorInicial;
            }
            public void Sumar(double termino)
            {
                numero += termino;
            }
            public void Restar(double termino)
            {
                numero -= termino;
            }
            public void Multiplicar(double termino)
            {
                numero *= termino;
            }
            public void Dividir(double termino)
            {
                if (termino != 0)
                {
                    numero /= termino;
                }
                else
                {
                    throw new DivideByZeroException("No se puede dividir por cero");
                }
            }
            public double Resultado
            {
                get => numero;
            }
            public void Limpiar()
            {
                numero = 0;
            }
        }
}

