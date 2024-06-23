using System.ComponentModel.DataAnnotations;

namespace AUTOMACTIC_INFOTECH_ASSIGMENT.Models
{
    public class Material
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Short_Text { get; set; }

        
        public string Long_Text { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public string Reorder_Level { get; set; }

        [Required]
        public string Min_Order_Quantity { get; set; }

        public bool IsActive { get; set; }
        
    }
}







