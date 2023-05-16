using objetos.clases;
using System;

namespace objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Persona persona = new Persona();

            persona.Nombre = "Maria";
            persona.Apellido = "Sosa";
            persona.Edad = 25;
            persona.Salario = 12313.33; 
            
            persona.ImprimirDatos();

            Console.WriteLine("--------------");
            Persona persona2 = new Persona();
            persona.Nombre = "Jose";
            persona.Apellido = "Alegria";
            persona.Edad = 19;
            persona.Salario = 13000.33;

            persona2.ImprimirDatos();
         
        }
    }
}
