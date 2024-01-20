using System;

class Aluno
{
    public string nome=null;
    public string situacao=null;
    public float notafinal;
    public string AvaliarAluno(float nota1, float nota2)
    {
        notafinal = nota1 + nota2 / 2;
        if  (notafinal >= 6)
        {
            return "aprovado";
        }
        else
        {
            return "reprovado";
        }
    }
}