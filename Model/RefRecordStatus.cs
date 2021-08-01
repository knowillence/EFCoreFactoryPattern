using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Knowillence.Yaapiyal.Model
{
    public class ref_record_status
    {
        //by default if the key is integer it is set as autoincrement
        [Key]
        public int record_status_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string record_status_name { get; set; }
        [MaxLength(500)]
        public string record_status_desc { get; set; }
    }
}
