
namespace Album_ObjetosEstáticos_;

internal class Album
{
    private static int ContadorDeObjetos;

    public Album(string nome)
    {
        Nome = nome;
        ContadorDeObjetos = 1;
    }
    public void ShowName()
    {
        Console.WriteLine("Nome: "+ Nome);
    }

    private string Nome {  get; }
    public static void CountObjetos()
    {
        Console.WriteLine("Foram instanciados : "+ ContadorDeObjetos+"Objetos dessa classe");
    }


}
