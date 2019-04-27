using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [StringLength(256)]
        public string Description { set; get; }

        [StringLength(256)]
      
        public string Image { set; get; }
        
        [StringLength(256)]
        public string URL { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }
    }
}