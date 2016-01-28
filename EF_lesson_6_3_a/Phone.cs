using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_6_3_a
{
    [Table("Mobiles")]
    public class Phone
    {
        public int Id { get; set; }
        [Column("ModelName")]
        [ConcurrencyCheck]
        public string Name { get; set; }

        public int? CompId { get; set; }
        [ForeignKey("CompId")]
        public Company Company { get; set; }
    }
}
