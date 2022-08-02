using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSK.Database
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Birthday { get; set; }
        [Column(TypeName = "bit")]
        public bool? Sex { get; set; }
        [Column(TypeName = "int")]
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Email { get; set; }
        [Column(TypeName = "char(20)")]
        public string? Phone { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Address { get; set; }
    }
}
