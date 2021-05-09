using System.ComponentModel.DataAnnotations;

namespace Models {
public class Person {
    [Key, Required]
    public int Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public string HairColor { get; set; }
    [Required]
    public string EyeColor { get; set; }
    [Required,Range(18,110, ErrorMessage = "This is not an adult")]
    public int Age { get; set; }
    [Required]
    public float Weight { get; set; }
    [Required]
    public int Height { get; set; }
    [Required]
    public string Sex { get; set; }
}


}