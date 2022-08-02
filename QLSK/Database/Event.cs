using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLSK.Database
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? DayStart { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? DayEnd { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Place { get; set; }
        [Column(TypeName = "nvarchar(MAX)")]
        public string? Require { get; set; }
        [Column(TypeName = "int")]
        public int TypeEvent { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string? Link { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public int Status { get; set; }
    }
}
