using Ex04_CAAL;

//Criar uma classe simples com um método e chame esse método
//em um objeto nulo. Tratar a exceção de método em objeto nulo.
Simpleclass Somador = null;
try
{
    Console.WriteLine(Somador.Somar());
}catch(Exception ex)
{
    Console.WriteLine($"Erro na impressão do retorno do método: {ex.Message}");
}
