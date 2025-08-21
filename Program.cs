using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");

Smartphone nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", "32");   
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");
Console.WriteLine("------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("987654321", "iPhone 13", "987654321098765", "128");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Safari");
Console.WriteLine("------------------------------");
