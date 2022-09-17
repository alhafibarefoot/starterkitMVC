namespace StarterKitAspNetCoreWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 

    public partial class AspNetUserLogin
    {

 // Add Primary Key with AspNetUsers---------------------------
        [Key]

        [StringLength(128)]

        [Column("UserId",Order = 0)]
        public string AspNetUserUserId { get; set; }
        public AspNetUser AspNetUser { get; set; }
//-----------------------------------------------------------------------------------

        [Key]
        [Column(Order = 1)]
        public string LoginProvider { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ProviderKey { get; set; }

      

       
    }
}
