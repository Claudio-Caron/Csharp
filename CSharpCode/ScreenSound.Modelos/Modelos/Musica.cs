﻿using ScreenSound.Modelos.Modelos;

namespace ScreenSound.Modelos;

public class Musica
{
    public Musica(string nome)
    {
        Nome = nome;
    }

    public virtual ICollection<Genero>  GenerosMusica { get; set; }= new List<Genero>();
    public string Nome { get; set; }
    public int Id { get; set; }
    public int AnoLancamento { get; set; }
    public virtual Artista? Artista { get; set; }

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
      
    }

    public override string ToString()
    {
        return @$"Id : {Id}\n
        Nome : {Nome}\n
        Ano de Lançamento : {AnoLancamento}\n";
    }
}