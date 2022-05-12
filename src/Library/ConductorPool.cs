using System;

namespace PII_Herencia
{
    public class ConductorPool : Conductor
    {
        public ConductorPool( string nombre, string apellido, int cedula, string vehiculo, int calificacion, string bio, int capacidad)
            : base(nombre, apellido, cedula, vehiculo, calificacion, bio)
        {
           this.capacidad = capacidad;
        }

        private int capacidad {get;} 
    }
}