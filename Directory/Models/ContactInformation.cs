using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Directory.Models
{
    public class ContactInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email{ get; set; }
        public string Location { get; set; }

        [ForeignKey("TID")]
        public int TID { get; set; }
        public TelephoneDirectory TelephoneDirectory { get; set; }

        


    }
}
