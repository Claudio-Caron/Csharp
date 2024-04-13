//Criar um programa que permite ao
//usuário inserir informações de uma pessoa
//(nome, idade, e e-mail), serializa essas
//informações em formato JSON e salva em um arquivo.
using Ex1_04CAAL;

CadastroPessoa Cadastro = new CadastroPessoa("Claudio", 19, "claudioandre11022005@gmail.com");
Cadastro.TransformarDadosEmJson();