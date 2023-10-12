namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANGHUY")]
    public partial class CHITIETDONHANGHUY
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MASANPHAM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MADONHANGHUY { get; set; }

        public int? SOLUONG { get; set; }

        public int? GIASANPHAM { get; set; }

        public virtual DONHANGHUY DONHANGHUY { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
