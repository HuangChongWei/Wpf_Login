namespace Wpf_Login.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 匯款資訊
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string 顧客 { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal 金額 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string 幣別 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string 匯款類別 { get; set; }

        [StringLength(10)]
        public string 匯款性質 { get; set; }

        [StringLength(10)]
        public string 匯款人 { get; set; }

        [StringLength(10)]
        public string 附言 { get; set; }

        [StringLength(10)]
        public string 原始金額 { get; set; }

        [StringLength(10)]
        public string 匯率 { get; set; }

        [StringLength(10)]
        public string 是否轉接 { get; set; }
    }
}
