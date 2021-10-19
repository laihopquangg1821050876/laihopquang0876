using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Laihopquang876
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }
        public string PersonName { get; set; }
    }
}