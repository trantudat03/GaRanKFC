namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DIEUKIEN")]
    public partial class DIEUKIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DIEUKIEN()
        {
            KHUYENMAIs = new HashSet<KHUYENMAI>();
        }

        [Key]
        [StringLength(25)]
        public string MADIEUKIEN { get; set; }

        [StringLength(255)]
        public string TENDIEUKIEN { get; set; }

        public int? DIEMTOITHIEU { get; set; }

        public int? GIATRIDONHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHUYENMAI> KHUYENMAIs { get; set; }
    }
}
