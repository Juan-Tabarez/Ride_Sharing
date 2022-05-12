using System;

namespace PII_Herencia
{
    public class Pasajero : User
    {
        
        public Pasajero (string nombre, string apellido, int cedula, int calificacion)
        :base(nombre, apellido, cedula, calificacion)
        {
            
        }
    }
}