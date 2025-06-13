using System;
using EspacioCalculadora;
class Program
{
    static void Main() {
        Calculadora calculadora = new Calculadora();
        string operacion;
        double numero;
        int opcion;
        do
        {
            Console.WriteLine("===MENU CALCULADORA===");
            Console.WriteLine("Presione 1 para usar la calculadora\nPresione 2 para ver el historial de la caluladora\nPresione 0 para salir del programa");
            Console.WriteLine("Elija un opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("---Bienvenido a la calculadora---\nNota: Escriba 'salir' en la operacion para terminar");
                    do
                    {
                        Console.Write("Ingrese una operacion (+, -, *, /): ");
                        operacion = Console.ReadLine();
                        if (operacion == "salir")
                            break;
                        Console.Write("Ingrese una numero: ");
                        if (!double.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("Número inválido. Intente de nuevo.");
                            continue;
                        }
                        switch (operacion)
                        {
                            case "+":
                                calculadora.Sumar(numero);
                                break;
                            case "-":
                                calculadora.Restar(numero);
                                break;
                            case "*":
                                calculadora.Multiplicar(numero);
                                break;
                            case "/":
                                calculadora.Dividir(numero);
                                break;
                            default:
                                Console.WriteLine("Operacion no valida");
                                continue;
                        }
                        Console.WriteLine($"Resultado: {calculadora.Resultado}");
                    } while (true);
                    break;
                case 2:
                    Console.WriteLine("---Bienvenido al historial de la calculadora---");
                    foreach (var op in calculadora.Historial)
                    {
                        Console.WriteLine($"Operación: {op.Tipo} - Resultado: {op.Resultado}");
                    }
                    break;
                case 0:
                    Console.WriteLine("===FIN DEL PROGRAMA===");
                    break;
                default:
                    Console.WriteLine("Opcion invalida: Ingrese un numero entre 0 y 2");
                    break;
            }

        } while (opcion != 0);
        

        
    }
}