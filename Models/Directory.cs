using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Directory.Models
{
    public class Directory
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
    }
}
