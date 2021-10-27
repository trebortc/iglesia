using System.ComponentModel.DataAnnotations.Schema;

namespace IglesiaModel.Model
{
    public class Parroco
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Titulo { get; set; }
        [Column("parroquia_id")]
        public int ParroquiaId { get; set; }
        public Parroquia Parroquia { get; set; }
    }
}
