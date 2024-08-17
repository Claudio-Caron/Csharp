// See https://aka.ms/new-console-template for more information
using Ex1_Geometricas;
using System;

Console.WriteLine("Hello, World!");
//Criar uma interface chamada IForma que declare métodos para calcular a área
//    e o perímetro de uma forma geométrica. Implemente esta interface
//    em duas classes: Circulo e Retangulo.
Circulo circulo = new Circulo();
circulo.MostrarDados();
circulo.CalcularArea(10);
circulo.MostrarDados();
circulo.CalcularPerimetro(10);
circulo.MostrarDados();
