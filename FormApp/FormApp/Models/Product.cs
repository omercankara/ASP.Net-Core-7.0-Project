using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormApp.Models
{
    public class Product
    {
        [Display(Name="ProductId")]
        public int ProductId { get; set; }

		[Display(Name = "Name")]
		[Required]

		public string Name { get; set; } = string.Empty;

		[Required]
        [Range(0, 5000)]
        [Display(Name="Price")]
		public decimal? Price { get; set; }

		[Display(Name= "Image")] 
		public string Image { get; set; } = string.Empty;

		[Display(Name="IsActive")]
		public bool IsActive { get; set; }

		[Required]
		[Display(Name= "Category")]
		public int CategoryId { get; set; }


		
    }
}
