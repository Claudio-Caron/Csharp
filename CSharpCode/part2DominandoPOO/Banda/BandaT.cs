namespace Aprendizadp.Banda
{
    internal class BandaT
    {
        public string Nome { get; }
        public AvaliarBanda Avaliar { get; set; }
        public BandaT(string nome)
        {
            Nome = nome;
        }
    }
}
