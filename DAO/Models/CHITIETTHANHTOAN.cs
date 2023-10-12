namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETTHANHTOAN")]
    public partial class CHITIETTHANHTOAN
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string MAPHUONGTHUC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string MADONHANG { get; set; }

        public int? SOTIENTRA { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual PHUONGTHUCTHANHTOAN PHUONGTHUCTHANHTOAN { get; set; }
    }
}
