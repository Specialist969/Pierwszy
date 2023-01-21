using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pierwszy.Models
{
    public class Filmy
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Tytul { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Opis { get; set; }
        [Column(TypeName = "int")]
        public int Ocena { get; set; }
    }
}
