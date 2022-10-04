using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia");
Smartphone nokia = new Nokia ("129999999", "Nokia", "148888888", 123);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("99taxi");

Console.WriteLine("/n");

Console.WriteLine($"Iphone");
Smartphone iphone = new Iphone ("127777777", "Iphone", "15666666666", 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("uber");