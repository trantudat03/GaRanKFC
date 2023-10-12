namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHUONGTHUCTHANHTOAN")]
    public partial class PHUONGTHUCTHANHTOAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHUONGTHUCTHANHTOAN()
        {
            CHITIETTHANHTOANs = new HashSet<CHITIETTHANHTOAN>();
        }

        [Key]
        [StringLength(25)]
        public string MAPHUONGTHUC { get; set; }

        [StringLength(255)]
        public string TENPHUONGTHUC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETTHANHTOAN> CHITIETTHANHTOANs { get; set; }
    }
}
