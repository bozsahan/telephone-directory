using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Directory.Models
{
    public class TelephoneDirectory
    {
        [Key]
        public int UUID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }

        [ForeignKey("TID")]
        public ContactInformation ContactInformation { get; set; }
    }
}
