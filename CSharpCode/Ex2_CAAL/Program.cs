//Escrever um programa que solicite dois números a e b lidos do teclado
//e realize a divisão de a por b. Caso essa operação não seja possível,
//mostrar uma mensagem no console que deixe claro o erro ocorrido.
using Ex2_CAAL;

Operacao op = new Operacao(10, 0);
Console.WriteLine($"Retorno de {op.A}/ {op.B} => {op.Dividir()}");