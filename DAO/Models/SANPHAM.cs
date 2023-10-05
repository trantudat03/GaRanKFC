namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            CHITIETDONHANGs = new HashSet<CHITIETDONHANG>();
        }

        [Key]
        [StringLength(25)]
        public string MASANPHAM { get; set; }

        [Required]
        [StringLength(25)]
        public string MALOAISP { get; set; }

        [StringLength(100)]
        public string TENSANPHAM { get; set; }

        public int? GIASANPHAM { get; set; }

        [StringLength(255)]
        public string ANHSANPHAM { get; set; }

        public int? THOIHAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANG> CHITIETDONHANGs { get; set; }

        public virtual LOAISANPHAM LOAISANPHAM { get; set; }

        public virtual SANPHAMHANGNGAY SANPHAMHANGNGAY { get; set; }
    }
}
