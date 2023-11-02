namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUOIDUNG()
        {
            DONHANGs = new HashSet<DONHANG>();
            DONHANGHUYs = new HashSet<DONHANGHUY>();
            DONHANGHUYs1 = new HashSet<DONHANGHUY>();
            THONGBAOHANGNGAYs = new HashSet<THONGBAOHANGNGAY>();
        }

        [Key]
        [StringLength(25)]
        public string MANGUOIDUNG { get; set; }

        [StringLength(100)]
        public string TENNGUOIDUNG { get; set; }

        [StringLength(20)]
        public string TENDANGNHAP { get; set; }

        [StringLength(255)]
        public string EMAIL { get; set; }

        [StringLength(12)]
        public string SODIENTHOAI { get; set; }

        [StringLength(20)]
        public string MATKHAU { get; set; }

        [Required]
        [StringLength(25)]
        public string MACHUCVU { get; set; }

        [Required]
        [StringLength(25)]
        public string MATRANGTHAI { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANGHUY> DONHANGHUYs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANGHUY> DONHANGHUYs1 { get; set; }

        public virtual TRANGTHAINGUOIDUNG TRANGTHAINGUOIDUNG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGBAOHANGNGAY> THONGBAOHANGNGAYs { get; set; }
    }
}
