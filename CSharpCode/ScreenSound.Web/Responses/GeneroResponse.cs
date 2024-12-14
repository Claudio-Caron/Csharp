using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Responses;

public record GeneroResponse([Required] string name, string description);