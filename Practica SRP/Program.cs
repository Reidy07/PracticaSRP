using Practica_SRP.Clases;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Persona persona = new Persona("Reidy Adrian", 30, "Calle Expresso #34", "reidybrown1234@gmail.com");

        Datos datos = new Datos();
        datos.ImprimirDatos(persona);

        Correo correo = new Correo();
        correo.EnviarCorreoElectronico(persona.CorreoElectronico, "Hola Reidy, este es su correo?.");
    }
}