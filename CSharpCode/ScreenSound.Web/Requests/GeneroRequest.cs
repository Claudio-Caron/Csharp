using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record GeneroRequest([Required]string Name, [Required]int Id, string Description);