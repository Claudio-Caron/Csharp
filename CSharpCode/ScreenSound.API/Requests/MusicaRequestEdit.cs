using System.Collections;
using System.ComponentModel.DataAnnotations;
using PersistindoDadosComEntityFC.Migrations;
using ScreenSound.Modelos;

namespace ScreenSound.API.Requests;

public record MusicaRequestEdit(string nome,int ArtistaId, int anoLancamento, int Id, ICollection<GeneroRequest> generos):
    MusicaRequest(nome, ArtistaId, anoLancamento, generos);