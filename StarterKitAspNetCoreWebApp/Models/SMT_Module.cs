namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
  

    public partial class SMT_Module:BaseEntity
    {
  
        public SMT_Module()
        {
          //  SEC_RolePermission = new HashSet<SEC_RolePermission>();
        }
        [Column(Order=0)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }

        [Key]
        [StringLength(12)]
        public string Module_Code { get; set; }

       

        [Required]
        [StringLength(100)]
        public string ModuleNameAr { get; set; }

        [StringLength(100)]
        public string ModuleNameEn { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        [StringLength(7)]
        public string TextColor { get; set; }

        [StringLength(7)]
        public string BackgroundColor { get; set; }

        [StringLength(100)]
        public string RouteController { get; set; }

        [StringLength(100)]
        public string RouteAction { get; set; }

        [StringLength(100)]
        public string RouteArea { get; set; }

        public string ModuleActions { get; set; }

        public int OrderSequence { get; set; }

        [StringLength(8)]
        public string ParentModuleCode { get; set; }

        public bool IsMenu { get; set; }

        [StringLength(150)]
        public string SystemTableName { get; set; }

        

      
    }
}
