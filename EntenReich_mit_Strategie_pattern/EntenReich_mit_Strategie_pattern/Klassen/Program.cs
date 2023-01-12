
using EntenReich_mit_Strategie_pattern.Klassen;


absclsEnte donald = new clsStockEnte();


donald.Aussehen();
donald.toFliegen();
donald.toQuacken();
//-------------------------
donald.SetFliegen(new clsFliegtGarNicht());
donald.SetQuacken(new clsQuitschen());
donald.toFliegen();
donald.toQuacken();