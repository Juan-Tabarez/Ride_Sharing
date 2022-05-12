using System;

namespace PII_Herencia
{
    public  class Conductor : User
    {
        
        private string vehiculo {get;} 

        private string bio {get;} 

        public Conductor (string nombre, string apellido, int cedula, string vehiculo, int calificacion, string bio)
            :base(nombre, apellido, cedula, calificacion)
        {
    
            this.vehiculo = vehiculo;
            this.bio = bio;
        }
    }
}