//Criar um programa que lê um arquivo
//JSON contendo informações de uma pessoa,
//desserializa essas informações e exibe na tela.
using System.IO;
using Ex1_04CAAL;
string retornoJson = File.ReadAllText(@"C:\Users\claud\OneDrive\Área de Trabalho\Programação\Linguagens-programação\C#_treinamento\Ex1_04CAAL\bin\Debug\net8.0\Dados do Usuário Claudio");
ShowJson.ExibirArquivoJson(retornoJson);