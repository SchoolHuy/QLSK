using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSK.Database
{
    public class Registration
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "int")]
        public int UID { get; set; }
        [Column(TypeName = "int")]
        public int EID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Status { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Note { get; set; }
    }
}
