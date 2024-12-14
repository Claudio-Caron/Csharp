namespace ScreenSound.API.Requests;

public record MusicaRequestEdit(string nome,int ArtistaId, int anoLancamento, int Id, ICollection<GeneroRequest> generos):
    MusicaRequest(nome, ArtistaId, anoLancamento, generos);