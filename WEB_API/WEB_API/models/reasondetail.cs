using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WEB_API.models
{
    
    public class reasondetail
    {
        [Key]
       
        public int id1 { get; set; }
      
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string startdate2 { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string enddate2 { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string process2 { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string reason2 { get; set; }
       


    }
}
