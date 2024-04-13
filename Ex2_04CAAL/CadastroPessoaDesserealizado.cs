using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ex2_04CAAL;

internal class CadastroPessoaDesserealizado
{
    [JsonPropertyName("nome")]
    public string? Nome {  get; set; }

    [JsonPropertyName("idade")]
    public int Idade {  get; set; }
    public override string ToString() => $"Nome : {Nome}\n Idade: {Idade}\n";

}
