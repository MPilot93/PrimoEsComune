using EsComune;

//nuovi corrieri
var corriere1 = new Corriere("SDA");
var corriere2 = new Corriere("GLS");

//nuove consegne
var multa = new Plico("Agenzia", "evasore", 5, 1, 2);
var posta = new Pacco("Wish", "Manuela", 2, 3, 5, 7);

corriere1.AddSpedizione(multa);
corriere1.AddSpedizione(posta);


Console.WriteLine("lista spedizione corriere1 " + "\n");
Console.WriteLine(corriere1.GetSpedizioni() + "\n");
Console.WriteLine($"per un totale ingombro di {corriere1.GetTotalIngombro()}" + "\n");

Console.WriteLine("i pacchi confrontati sono uguali?" + "\n");


//esempio metodo equals
if (multa.Equals(posta))
{
    Console.WriteLine("Si, sono uguali");
}

else Console.WriteLine("No, non sono uguali");
