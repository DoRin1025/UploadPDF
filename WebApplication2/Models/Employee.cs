using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [NotMapped]
        public HttpPostedFileBase File { get; set; }

        [NotMapped]
        public String ImageUrl
        {
            get { return Id.ToString() + ".pdf"; }

        }
    }
}