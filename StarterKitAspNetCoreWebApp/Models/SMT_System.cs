namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class SMT_System:BaseEntity
    {
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            
        [Key]
        [StringLength(12)]
        public string System_Code { get; set; }

       
        [Required]
        [StringLength(100)]
        public string SystemNameAr { get; set; }

        [StringLength(100)]
        public string SystemNameEn { get; set; }

        [StringLength(10)]
        public string SystemAbbreviationAr { get; set; }

        [StringLength(10)]
        public string SystemAbbreviationEn { get; set; }

        public byte[] BackgroundImageUrl { get; set; }

        public byte[] Logo { get; set; }

        [StringLength(7)]
        public string BackgroundColor { get; set; }

        [StringLength(7)]
        public string FontColor { get; set; }

       
    }
}
