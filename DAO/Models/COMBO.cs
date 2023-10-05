namespace DAO.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMBO")]
    public partial class COMBO
    {
        [Key]
        [StringLength(25)]
        public string MACOMBO { get; set; }

        [StringLength(255)]
        public string TENCOMBO { get; set; }

        public int? GIACOMBO { get; set; }

        public int? TONGSLSPHAM { get; set; }

        [StringLength(255)]
        public string ANH { get; set; }
    }
}
