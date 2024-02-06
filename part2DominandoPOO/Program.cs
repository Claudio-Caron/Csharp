// See https://aka.ms/new-console-template for more information
using Aprendizadp.Banda;

BandaT Band = new BandaT("Mamonas");
Console.WriteLine($"Insira uma nota para a banda {Band.Nome}:");
Band.Avaliar= AvaliarBanda.Parse(Console.ReadLine()!);
Console.WriteLine($"Nota recebida da Banda {Band.Nome} e : {Band.Avaliar.Nota}\n");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine($"Insira uma nova nota para a banda {Band.Nome}");
Band.Avaliar.Nota=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Nova Nota recebida da Banda {Band.Nome} e : {Band.Avaliar.Nota}\n");