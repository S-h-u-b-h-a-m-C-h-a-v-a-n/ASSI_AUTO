using System.ComponentModel.DataAnnotations;

namespace VendorApp.Models
{
    public class Vendor
    {
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address_Line_1 { get; set; }

        
        public string Address_Line_2 { get; set; }

        [Required]
        public string Contact_Email { get; set; }

        [Required]
        public string Contact_No { get; set; }

        [Required]
        public string Valid_Till_Date { get; set; }

        
        public bool IsActive { get; set; }



        // Additional properties if needed
    }
}
