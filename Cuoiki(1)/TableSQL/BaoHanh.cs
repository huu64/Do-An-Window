namespace Cuoiki_1_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaoHanh")]
    public partial class BaoHanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaoHanh()
        {
            LichSuBaoHanhs = new HashSet<LichSuBaoHanh>();
        }

        [Key]
        public int MaBaoHanh { get; set; }

        public int? MaXe { get; set; }

        public DateTime? NgayMua { get; set; }

        public int? ThoiHanBaoHanh { get; set; }

        public virtual Xe Xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuBaoHanh> LichSuBaoHanhs { get; set; }
    }
}
