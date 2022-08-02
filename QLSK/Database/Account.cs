using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSK.Database
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int UID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Password { get; set; }
    }
}
