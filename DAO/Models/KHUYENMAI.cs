namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHUYENMAI")]
    public partial class KHUYENMAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYENMAI()
        {
            DONHANGs = new HashSet<DONHANG>();
        }

        [Key]
        [StringLength(25)]
        public string MAKHUYENMAI { get; set; }

        [StringLength(255)]
        public string TENKHUYENMAI { get; set; }

        public int? PHANTRAM { get; set; }

        public int? SOTIENGIAM { get; set; }

        public int? SOTIENGIAMTOIDA { get; set; }

        [Required]
        [StringLength(25)]
        public string MADIEUKIEN { get; set; }

        public DateTime? NGAYKETTHUC { get; set; }

        public DateTime? NGAYBATDAU { get; set; }

        public virtual DIEUKIEN DIEUKIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}
