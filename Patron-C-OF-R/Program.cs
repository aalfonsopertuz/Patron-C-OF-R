using Patron_C_OF_R.Patron;

var level1 = new Level1Support();
var level2 = new Level2Support();
var level3 = new Level3Support();

level1.SetNext(level2);
level2.SetNext(level3);

Console.WriteLine("Enviando una solicitud 'Simple':");
level1.HandleRequest("Simple");

Console.WriteLine("\nEnviando una solicitud 'Intermedia':");
level1.HandleRequest("Intermediate");

Console.WriteLine("\nEnviando una solicitud 'Compleja':");
level1.HandleRequest("Complex");