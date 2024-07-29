using System;

namespace Practica_SRP.Clases
{
    public class Correo

    {
        public void EnviarCorreoElectronico(string correoElectronico, string mensaje)
        {
            
            Console.WriteLine($"Eviando el correo a {correoElectronico}: {mensaje}");

        }
    }
}
