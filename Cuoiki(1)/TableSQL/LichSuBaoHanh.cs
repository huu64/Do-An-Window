namespace Cuoiki_1_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuBaoHanh")]
    public partial class LichSuBaoHanh
    {
        [Key]
        public int MaLichSuBaoHanh { get; set; }

        public int? MaBaoHanh { get; set; }

        [StringLength(100)]
        public string LoaiDichVu { get; set; }

        public DateTime? NgayThucHien { get; set; }

        public virtual BaoHanh BaoHanh { get; set; }
    }
}
