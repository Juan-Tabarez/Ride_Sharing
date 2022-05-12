using System;

namespace PII_Herencia
{
    public class User
    {
        private string nombre {get;} 

        private string apellido {get;} 

        private int cedula {get;} 

        private int calificacion {get;} 

        public User(string nombre, string apellido, int cedula, int calificacion)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.calificacion = calificacion;
        }
    }
}