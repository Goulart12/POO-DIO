using POO.Entities;

Knight arus = new Knight("Arus", 23, "Knight");
Wizard jennica = new Wizard("Jennica", 42, "Wizard");
Ninja wedge = new Ninja("Wedge", 42, "Ninja");
Warlock topapa = new Warlock("Topapa", 53, "Warlock");


Console.WriteLine(arus.Attack(1));
Console.WriteLine(jennica.Attack(7));
Console.WriteLine(wedge.Attack(8));
Console.WriteLine(topapa.Attack(2));
