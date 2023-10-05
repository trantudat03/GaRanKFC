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
            THONGBAOHANGNGAYs = new HashSet<THONGBAOHANGNGAY>();
        }

        [Key]
        [StringLength(25)]
        public string MANGUOIDUNG { get; set; }

        [StringLength(100)]
        public string TENNGUOIDUNG { get; set; }

        [StringLength(20)]
        public string TENDANGNHAP { get; set; }

        [StringLength(20)]
        public string MATKHAU { get; set; }

        [Required]
        [StringLength(25)]
        public string MACHUCVU { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THONGBAOHANGNGAY> THONGBAOHANGNGAYs { get; set; }
    }
}
