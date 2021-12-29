using System.ComponentModel.DataAnnotations.Schema;

namespace IglesiaModel.Model
{
    [Table("referencia_fisica")]
    public class ReferenciaFisica
    {
        public int Id { get; set; }
        public string Libro { get; set; }
        public string Pagina { get; set; }
        public string Acta { get; set; }
        [Column("bautizo_id")]
        public int BautizoId { get; set; }
        public Bautizo Bautizo { get; set; }
    }
}
