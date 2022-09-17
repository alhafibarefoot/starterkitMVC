using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StarterKitAspNetCoreWebApp.CustomAttributes;

namespace StarterKitAspNetCoreWebApp.Models
{
    public class BaseEntity
    {


       [Column(Order = 601)]
       [SqlDefaultValue("'EF Migration'")]
       [StringLength(100)]
       [Display(Name = "CreatedBy", ResourceType = typeof(AppResources.AppLanguage))]
        public string CreatedBy { get; set; }

       [Column(Order = 602)]
       [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
       [SqlDefaultValue("getutcdate()")]
       [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
       [Display(Name = "CreatedOn", ResourceType = typeof(AppResources.AppLanguage))]
        public DateTime? CreatedOn { get; set; }



       [Column(Order = 603)] 
       [SqlDefaultValue("'EF Migration'")]
       [StringLength(100)]
       [Display(Name = "ModifiedBy", ResourceType = typeof(AppResources.AppLanguage))]
       public string ModifiedBy { get; set; }


        [Column(Order = 604)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [SqlDefaultValue("getutcdate()")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "ModifiedOn", ResourceType = typeof(AppResources.AppLanguage))]
        public DateTime? ModifiedOn { get; set; }



        [Column(Order = 605)]
        [SqlDefaultValue("'::1'")]
        [StringLength(15)]
        [Display(Name = "IPAddress", ResourceType = typeof(AppResources.AppLanguage))]
        public string IPAddress { get; set; }


        [Column(Order = 606)]
        [SqlDefaultValue("1")]
        [Display(Name = "isActive", ResourceType = typeof(AppResources.AppLanguage))]
        public bool? isActive { get; set; }

//  protected BaseEntity()
//     {
//         isActive = true;
//         CreatedBy ="EF Migrations";
//         ModifiedBy="EF Migrations";
//         IPAddress="EF Migrations";
//         CreatedOn=new DateTime();
//         CreatedOn=new DateTime();
//     }
        
        
    }

}