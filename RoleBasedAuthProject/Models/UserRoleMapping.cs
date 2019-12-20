using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoleBasedAuthProject.Models
{
    public class UserRoleMapping
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //[ForeignKey("User")]
        public int UserId { get; set; }

        //[ForeignKey("Role")]
        public int RoleId { get; set; }
    }
}