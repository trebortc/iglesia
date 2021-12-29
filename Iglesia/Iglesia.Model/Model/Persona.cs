using IglesiaModel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace IglesiaModel.Model
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        [Column("fecha_nacimiento")]
        public DateTime FechaNacimiento { get; set; }
        public string Nacionalidad { get; set; }
        public string Cedula { get; set; }
        public SexoEnum Sexo { get; set; }
    }
}
