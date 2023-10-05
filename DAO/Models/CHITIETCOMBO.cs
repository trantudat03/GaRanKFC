namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETCOMBO")]
    public partial class CHITIETCOMBO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MASANPHAM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MACOMBO { get; set; }

        public int? SOLUONG { get; set; }
    }
}
