using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos.clases
{
    //clase es una plantlla, que contiene objetos y métodos 
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get;set; }
        public double Salario { get; set; } //double por su tamaño de la variable

        public void ImprimirDatos()
        {
            Console.WriteLine("Tu nombre es:" + this.Nombre);
            Console.WriteLine("Tu apellido es:" + this.Apellido);
            Console.WriteLine("Tu edad es:" + this.Edad);
            Console.WriteLine("Tu salario es:" + this.Salario);
        }

    }
}
