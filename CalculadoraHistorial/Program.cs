using System;
using EspacioCalculadora;
class Program
{
    static void Main() {
        Calculadora calculadora = new Calculadora();
        string operacion;
        double numero;
        Console.WriteLine("Programa: Calculadora");
        Console.WriteLine("Nota: Escriba 'salir' en la operacion para terminar el programa");

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
    }
}