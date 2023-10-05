namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGBAOHANGNGAY")]
    public partial class THONGBAOHANGNGAY
    {
        [Key]
        [StringLength(25)]
        public string MATHONGBAO { get; set; }

        [StringLength(255)]
        public string TENTHONGBAO { get; set; }

        [StringLength(255)]
        public string NOIDUNG { get; set; }

        public DateTime? THOIGIANHIEN { get; set; }

        public int? CHECK { get; set; }

        public int? TYPE { get; set; }

        [Required]
        [StringLength(25)]
        public string MANGUOIDUNG { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
