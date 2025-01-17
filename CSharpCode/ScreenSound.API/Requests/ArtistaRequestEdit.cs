using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record ArtistaRequestEdit(string nome,string bio, int id,string? fotoPerfil):
    ArtistaRequest(nome, bio, fotoPerfil);