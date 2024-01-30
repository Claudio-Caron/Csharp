/*Modelar o sistema de uma escola.
 * Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações 
 * como nome, idade e notas. A classe Professor deve ter informações
 * sobre nome e disciplinas lecionadas. 
 * A classe Disciplina deve armazenar o nome da disciplina
 * e a lista de alunos matriculados.*/

class Aluno {

    public Aluno(string nome)
    {
        Nome = nome;
    }  
    public float Nota { get; set; }
    public int Idade { get; set; } 
    public string Nome { get; }
    public void AdicionarNota()
    { 
        Console.Clear();
        Console.WriteLine($"Insira uma nota para o aluno {Nome}");
        Nota=float.Parse( Console.ReadLine()!);
    }
}

class Professor
{
    public string Nome { get; set; }
    public string DisLesc { get; set; }
    public Professor(string nome, string disLesc)
    {
        Nome = nome;
        DisLesc = disLesc;
    }
}
class Disciplina
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; }
    public Disciplina(string nome)
    {
        Nome=nome;
        Alunos = new List<Aluno>(); 
    }
    public void CadastrarAluno()
    {
        Console.Clear();
        Console.WriteLine("Insira o nome do Aluno:");
        string nome=Console.ReadLine()!;
        Aluno Cadastro= new Aluno(nome);
        Console.WriteLine("Qual a idade do aluno?");
        Cadastro.Idade=int.Parse(Console.ReadLine()!); 
        Alunos.Add(Cadastro);
        Console.WriteLine("Pressione qualquer tecla para prosseguir");
        Console.ReadKey();  
        Console.Clear();
    }
    public void AlterarNota()
    {
        Console.Clear();
        Aluno Busca= new Aluno("teste");
        Alunos.ForEach(x => Console.WriteLine(x));
        Console.WriteLine("\n\nQual dos alunos voce deseja alterara a nota?");
        string aux = Console.ReadLine()!;
        Busca=Alunos.Find(x => x.Nome == aux);
        Console.WriteLine($"Insira a nota do Aluno {aux}");
    }
}