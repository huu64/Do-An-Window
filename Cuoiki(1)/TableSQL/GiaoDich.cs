namespace Cuoiki_1_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoDich")]
    public partial class GiaoDich
    {
        [Key]
        public int MaGiaoDich { get; set; }

        public int? MaKhachHang { get; set; }

        public int? MaXe { get; set; }

        public DateTime? NgayGiaoDich { get; set; }

        public decimal? GiaGiaoDich { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Xe Xe { get; set; }
    }
}
