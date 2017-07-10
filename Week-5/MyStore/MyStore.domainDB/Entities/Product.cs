using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MyStore.domainDB.Entities
{
    //product class
    public class Product
    {
       [System.Web.Mvc.HiddenInput(DisplayValue =false)]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Please enter a product name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a product Description")]
        [DataType(DataType.MultilineText)]
        public string ProductDescription { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Please enter a positive price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a product Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Please enter a product Subcategor")]
                public string SubCategory { get; set; }

        [Required(ErrorMessage = "Please enter a product Author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter a product Publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter a product ISBN")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Please enter a product ImageURL")]
        public string Image { get; set; }

        //[Required(ErrorMessage = "Please upload Image")]
        public byte[] ImageData { get; set; }

        public string ImageMimeType { get; set; }

        //public int SubCategoryId { get; set; }

        //public virtual SubCategory SubCategories { get; set; }

    }


    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }



    }

    public class SubCategory
    {
        public int SubCategoryId { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}