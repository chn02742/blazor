using System.ComponentModel.DataAnnotations;


namespace NewEra.Blazor.Components.Models
{
    public class InputLoginModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
