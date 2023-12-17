using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("================= Meu Iphone ====================");
System.Console.WriteLine();
Iphone meuIPhone = new Iphone("8199999699", "IphoneXR", "12345670987abcd", 250);
meuIPhone.InstalarAplicativo("Duolingo");

System.Console.WriteLine();

System.Console.WriteLine("================= Meu Nokia ====================");
System.Console.WriteLine();
Nokia meuNokia = new Nokia("819999283", "Nokia 6110", "1234jkdaljdla", 12);
meuNokia.InstalarAplicativo("Snake");