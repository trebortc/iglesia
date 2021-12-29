using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IglesiaModel.Model
{
    public class Bautizo
    {
        public int Id { get; set; }
        [Column("nombres_apellidos_bautizado")]
        public string NombresApellidosBautizado { get; set; }
        [Column("nombres_apellidos_padre")]
        public string NombresApellidosPadre { get; set; }
        [Column("nombres_apellidos_madre")]
        public string NombresApellidosMadre { get; set; }
        [Column("nombres_apellidos_padrino")]
        public string NombresApellidosPadrino { get; set; }
        [Column("nombres_apellidos_madrina")]
        public string NombresApellidosMadrina { get; set; }
        public string Celebrante { get; set; }
        [Column("parroquia")]
        public string NombreParroquia { get; set; }
        [Column("fecha_bautizo")]
        public DateTime FechaBautizo { get; set; }
        public string Observaciones { get; set; }
        public int BautizadoId { get; set; }
        public Persona Bautizado { get; set; }
        public int PadreId { get; set; }
        public Persona Padre { get; set; }
        public int MadreId { get; set; }
        public Persona Madre { get; set; }
        public int PadrinoId { get; set; }
        public Persona Padrino { get; set; }
        public int MadrinaId { get; set; }
        public Persona Madrina { get; set; }
        public int ParroquiaId { get; set; }
        public Parroquia Parroquia { get; set; }
        public int ParrocoId { get; set; }
        public Parroco Parroco { get; set; }
    }
}
