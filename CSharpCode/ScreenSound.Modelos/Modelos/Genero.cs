using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos.Modelos
{
    public class Genero
    {
        public string? Name { get; set; } = string.Empty;
        public int Id { get; set; }
        public string? Description { get; set; } = string.Empty;

        public virtual ICollection<Musica> Musicas { get; set; } = new List<Musica>();

        public override string ToString()
        {
            return $"Genero : {Name} - Description : {Description}";
        }
    }
}
