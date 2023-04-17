/*1. Creare una classe Rettangolo con due attributi interi: baseRettangolo e altezzaRettangolo.
Aggiungere un opportuno costruttore con parametri.
Aggiungere due metodi: calcolaArea e calcolaPerimetro che calcolano e restituiscono, rispettivamente, l’area e il perimetro del rettangolo.
2. Poi, nel vostro programma principale (Program.cs) chiedete all’utente di inserire, da console, i valori di base e di altezza con cui istanziare un nuovo Rettangolo.
Dopo averlo istanziato, stampate a video il perimetro e l’area del rettangolo che avete costruito.
3. Provate ad istanziare tanti rettangoli con nome diverso e attributi diversi (baseRettangolo e altezzaRettangolo cambiati)
e provate a stampare le loro proprietà ad esempio con un metodo StampaRettangolo che vi stampi il vostro rettangolo ad esempio cosi:
 —— Rettangolo ——
base: 20 cm
altezza: 10 cm
Perimetro: 60 cm
Area: 200 cm2
 */

using Geometria;

Rettangolo rettangolo1 = new Rettangolo(4, 2);

Console.WriteLine("Rettangolo 1");

Console.WriteLine("Base: " + rettangolo1.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo1.altezzaRettangolo + " cm");
Console.WriteLine("Area: " + rettangolo1.CalcolaArea() + " cm2");
Console.WriteLine("Perimetro: " + rettangolo1.CalcolaPerimetro() + " cm");

Console.WriteLine();

Rettangolo rettangolo2 = new Rettangolo(10, 20);

Console.WriteLine("Rettangolo 2");

Console.WriteLine("Base: " + rettangolo2.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo2.altezzaRettangolo + " cm");
Console.WriteLine("Area: " + rettangolo2.CalcolaArea() + " cm2");
Console.WriteLine("Perimetro: " + rettangolo2.CalcolaPerimetro() + " cm");

Console.WriteLine();

Rettangolo rettangolo3 = new Rettangolo(44, 70);

Console.WriteLine("Rettangolo 3");

Console.WriteLine("Base: " + rettangolo3.baseRettangolo + " cm");
Console.WriteLine("Altezza: " + rettangolo3.altezzaRettangolo + " cm");
Console.WriteLine("Area: " + rettangolo3.CalcolaArea() + " cm2");
Console.WriteLine("Perimetro: " + rettangolo3.CalcolaPerimetro() + " cm");