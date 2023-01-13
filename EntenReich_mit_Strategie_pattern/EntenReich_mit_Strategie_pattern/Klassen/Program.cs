
using EntenReich_mit_Strategie_pattern.Klassen;


absclsEnte donald = new clsStockEnte();
absclsEnte daisy = new clsMoorEnte();
absclsEnte gustav = new clsGummiEnte();
absclsEnte lightning = new clsHolzEnte();
//Stockente
Console.WriteLine("Stockente:");
donald.Aussehen();
donald.toFliegen();
donald.toQuacken();
//-------------------------
Console.WriteLine();
Console.WriteLine("Veränderte Ausgabe:");
donald.SetFliegen(new clsFliegtGarNicht());
donald.SetQuacken(new clsQuitschen());
donald.toFliegen();
donald.toQuacken();
Console.WriteLine("___________________________________________________________________________________________________");
Console.WriteLine();

//Moorente
Console.WriteLine("Moorente:");
daisy.Aussehen();
daisy.toFliegen();
daisy.toQuacken();
Console.WriteLine();

Console.WriteLine("Veränderte Ausgabe:");
daisy.SetFliegen(new clsFliegtGarNicht());
daisy.SetQuacken(new clsQuitschen());
daisy.toFliegen();
daisy.toQuacken();
Console.WriteLine("___________________________________________________________________________________________________");
Console.WriteLine();

//Gummiente
Console.WriteLine("Gummiente:");
gustav.Aussehen();
gustav.toFliegen();
gustav.toQuacken();
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Veränderte Ausgabe");
gustav.SetFliegen(new clsFliegtmitFlügel());
gustav.SetQuacken(new clsQuacken());
gustav.toFliegen();
gustav.toQuacken();
Console.WriteLine("___________________________________________________________________________________________________");
Console.WriteLine();

//Holzente
Console.WriteLine("Holzente:");
lightning.Aussehen();
lightning.toFliegen();
lightning.toQuacken();
Console.WriteLine();

Console.WriteLine("Veränderte Ausgabe");
lightning.SetFliegen(new clsFliegtmitFlügel());
lightning.SetQuacken(new clsQuacken());
lightning.toFliegen();
lightning.toQuacken();
Console.WriteLine("___________________________________________________________________________________________________");



Console.ReadKey();