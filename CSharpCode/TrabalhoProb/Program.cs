using TrabalhoProb;

List<IMC> iMCs = new List<IMC>();
while (true)
{
    
    Console.WriteLine("Peso : ");
    double peso = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Altura : ");
    double altura = Convert.ToDouble(Console.ReadLine());
    if (altura == 0 || peso == 0 )
        break;
    iMCs.Add(new IMC(altura, peso));
}
foreach (IMC iMC in iMCs)
{
    Console.WriteLine(iMC.CalcularImc().ToString("F2")+ "\n");
}
