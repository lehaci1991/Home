using Home4Us_Models.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Home4Us_Models
{
    public class Users : BaseClassID
    {

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20)]
        public string Passwrd { get; set; }

        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

    }
}