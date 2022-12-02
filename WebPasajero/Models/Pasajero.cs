using System;

namespace WebPasajero.Models
{
    public class Pasajero
    {
        public int Id { get; set; }  
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; } 

        public string Ciudad { get; set; }
    }
}
