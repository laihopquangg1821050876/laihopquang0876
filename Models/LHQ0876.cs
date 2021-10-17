using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laihopquang876.Models
{
    [Table("LHQ0876")]
    public class LHQ0876
    {
        [Key]
        public string LHQid { get; set; }
        public string LHQName { get; set; }
        public string LHQGendeR {get; set; }
    }
}
