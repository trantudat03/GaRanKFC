namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETDONHANG")]
    public partial class CHITIETDONHANG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MASANPHAM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MADONHANG { get; set; }

        public int? SOLUONG { get; set; }

        public int? GIASANPHAM { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
