
using System.ComponentModel.Design;

namespace Aprendizadp.Banda;

internal class AvaliarBanda
{
    private int _nota;
    public int Nota
    {

        get { return _nota; }
        set
        {
            if (value < 0)
            {
                _nota = 0;
            }
            else if (Nota > 10)
            {
                _nota = 10;
            }
            else
            {
                _nota = value;
            }
        }
    }
    public AvaliarBanda(int nota)
    {
        Nota = nota;
    }

    public static AvaliarBanda Parse(string nota)
    {
        if (int.Parse(nota) < 0)
        {
            return new AvaliarBanda(0);
        }
        else if (int.Parse(nota) > 10)
        {
            return new AvaliarBanda(10);
        }
        else
        {
            return new AvaliarBanda(int.Parse(nota));
        }
    }
    public void MostrarNota()
    {
        Console.WriteLine(_nota);
    }

}
