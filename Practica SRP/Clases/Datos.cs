using System;
namespace Practica_SRP.Clases
{
    public class Datos
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
        }
    }
}
