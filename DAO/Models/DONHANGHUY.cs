namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANGHUY")]
    public partial class DONHANGHUY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANGHUY()
        {
            CHITIETDONHANGHUYs = new HashSet<CHITIETDONHANGHUY>();
        }

        [Key]
        [StringLength(25)]
        public string MADONHANGHUY { get; set; }

        [Required]
        [StringLength(25)]
        public string MANGUOIDUNG { get; set; }

        [StringLength(25)]
        public string MAKHACHHANG { get; set; }

        public int? TONGGIA { get; set; }

        public int? SOLUONGSP { get; set; }

        public DateTime? THOIGIAN { get; set; }

        [StringLength(255)]
        public string LYDO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETDONHANGHUY> CHITIETDONHANGHUYs { get; set; }
    }
}
