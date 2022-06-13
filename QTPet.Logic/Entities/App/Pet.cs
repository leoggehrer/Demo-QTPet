using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTPet.Logic.Entities.App
{
    [Table("Pets", Schema = "App")]
    [Index(nameof(Name), nameof(Owner), IsUnique = true)]
    public class Pet : VersionEntity
    {
        [MaxLength(256)]
        public string? Owner { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }
}
