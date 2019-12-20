using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoleBasedAuthProject.Models
{
    public class Employee
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public DateTime HireDate { get; set; }
        public int Salary { get; set; }

        //[ForeignKey("Department")]
        public int DepartmentId { get; set; }
    }
}