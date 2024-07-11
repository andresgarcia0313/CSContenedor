using System;

namespace HelloWorldApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");

            Console.WriteLine("¿Cómo te llamas?");
            string nombre = Console.ReadLine() ?? "Invitado";

            var app = new HelloWorldApp();
            if (!string.IsNullOrEmpty(nombre))
            {
                app.Saludar(nombre);
            }
        }
    }

    class HelloWorldApp
    {
        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola, {nombre}! ¡Bienvenido a mi aplicación!");
        }
    }
}
