using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Directory.Models
{
    public class ContactInformation
    {    
        public string PhoneNumber { get; set; }
        public string Email{ get; set; }
        public string Location { get; set; }

        public Collection<TelephoneDirectory> TelephoneDirectory { get; set; }
        
    }
}
