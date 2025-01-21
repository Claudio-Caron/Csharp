using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Responses;

public record GeneroResponse([Required] int id, [Required] string name, string description);