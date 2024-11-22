﻿using System.ComponentModel.DataAnnotations;
using ScreenSound.Modelos;

namespace ScreenSound.API.Requests;

public record MusicaRequestEdit(string nome,int ArtistaId, int anoLancamento, int Id):
    MusicaRequest(nome, ArtistaId, anoLancamento);