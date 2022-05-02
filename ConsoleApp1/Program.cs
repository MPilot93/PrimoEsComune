using EsComune;

var corriere1 = new Corriere("SDA");
var corriere2 = new Corriere("GLS");

var multa = new Plico("Agenzia", "evasore", 5, 1, 2);
var posta = new Pacco("Wish", "madre", 2, 3, 5, 7);

corriere1.AddSpedizione(multa);
corriere2.AddSpedizione(posta);

Console.WriteLine("lista spedizione corriere1");
Console.WriteLine(corriere1.GetSpedizioni());
Console.WriteLine($"per un totale ingombro di {corriere1.GetTotalIngombro()}");