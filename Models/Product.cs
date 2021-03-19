using System.ComponentModel.DataAnnotations;

namespace dio_mvc.Models
{
  public class Product
  {
    public int Id { get; set; }

    [Required(ErrorMessage="The description field is mandatory.")]
    public string Description { get; set; }
    [Range(1, 10, ErrorMessage="Value out of range.")]
    public int Quantity { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

  }
}