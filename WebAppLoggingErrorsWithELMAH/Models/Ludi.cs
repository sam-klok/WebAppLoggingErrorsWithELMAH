using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAppLoggingErrorsWithELMAH.Models
{
    [Table("Ludi")]
    public class Ludi
    {
        [Key]
        [Required]
        public int PersonID { get; set; }
        public string Name { get; set; }
        public int?  PhoneID { get; set;}
    }
}