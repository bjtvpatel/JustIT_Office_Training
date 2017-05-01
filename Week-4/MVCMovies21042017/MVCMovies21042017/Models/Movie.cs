//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCMovies21042017.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(60, MinimumLength = 2)]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date, ErrorMessage ="not valid dataentry")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode =true)]
        public Nullable<System.DateTime> ReleaseDate { get; set; }

        [Required(ErrorMessage = "Genre is required")]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s\s-]*$")]
        public string Genre { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0,1000)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}