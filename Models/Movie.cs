using BlazorMovieApp.Models.ValidationAttributes;
using System.ComponentModel.DataAnnotations;

namespace BlazorMovieApp.Models;

public class Movie
{
    public int Id { get; set; }


    [Required(ErrorMessage = "This field is required.")]
    public string Title { get; set; } = string.Empty;


    [Required]
    [DataType(DataType.DateTime)]
    [ReleaseDateValidation]
    [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; }


    [Required(ErrorMessage = "This field is required.")]
    public string Genre { get; set; } = string.Empty;


    [Range(1, 100, ErrorMessage = "The value must be between 1 and 100.")]
    public decimal Price { get; set; }
}