namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
            CHITIETTHANHTOANs = new HashSet<CHITIETTHANHTOAN>();
        }

        [Key]
        [StringLength(25)]
        public string MADONHANG { get; set; }

        [Required]
        [StringLength(25)]
        public string MANGUOIDUNG { get; set; }

        [StringLength(25)]
        public string MAKHACHHANG { get; set; }

        [StringLength(25)]
        public string MAKHUYENMAI { get; set; }

        public int? TONGGIA { get; set; }

        public int? SOLUONGSP { get; set; }

        public DateTime? THOIGIAN { get; set; }

        public int? GIATRIKHUYENMAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTHANHTOAN> CHITIETTHANHTOANs { get; set; }

        public virtual KHACHHANG KHACHHANG { get; set; }

        public virtual KHUYENMAI KHUYENMAI { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }
    }
}
