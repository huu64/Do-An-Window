namespace Cuoiki_1_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuGiaoDich")]
    public partial class LichSuGiaoDich
    {
        [Key]
        public int MaGiaoDich { get; set; }

        public int? MaXe { get; set; }

        public int? MaUser { get; set; }

        [Required]
        [StringLength(50)]
        public string LoaiGiaoDich { get; set; }

        public DateTime? ThoiGian { get; set; }

        [StringLength(200)]
        public string MoTa { get; set; }

        public virtual User User { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
