namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAMHANGNGAY")]
    public partial class SANPHAMHANGNGAY
    {
        [Key]
        [StringLength(25)]
        public string MASANPHAM { get; set; }

        public int? SOLUONG { get; set; }

        public DateTime? THOIHANBATDAU { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
