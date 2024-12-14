using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record ArtistaRequestEdit([Required]string nome, [Required]string bio, [Required] int id,string fotoPerfil):
    ArtistaRequest(nome, bio, fotoPerfil);