namespace Cuoiki_1_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            BaoHanhs = new HashSet<BaoHanh>();
            GiaoDiches = new HashSet<GiaoDich>();
            LichSuGiaoDiches = new HashSet<LichSuGiaoDich>();
        }

        [Key]
        public int MaXe { get; set; }

        [StringLength(100)]
        public string TenXe { get; set; }

        [StringLength(50)]
        public string LoaiXe { get; set; }

        public decimal? GiaThanh { get; set; }

        [StringLength(50)]
        public string PhanKhoi { get; set; }

        [StringLength(50)]
        public string HangXe { get; set; }

        public int? UserID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaoHanh> BaoHanhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiaoDich> GiaoDiches { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuGiaoDich> LichSuGiaoDiches { get; set; }

        public virtual User User { get; set; }
    }
}
