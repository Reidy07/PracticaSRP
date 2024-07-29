/* lA SRP establece que una clase debe tener una única razón para cambiar, lo que significa que debe tener solo una responsabilidad o tarea.
 
La clase también contiene un método para enviar correos electrónicos (EnviarCorreoElectronico).*/


using System;
namespace Practica_SRP.Clases
{
    public class Persona
    {
        public string Nombre {  get; private set; }
        public int Edad {  get; private set; }
        public string Direccion {  get; private set; }
        public string CorreoElectronico { get; private set; }
        
        public Persona (string nombre, int edad, string direccion, string correoElectronico)
        {
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
        }
    }
}
