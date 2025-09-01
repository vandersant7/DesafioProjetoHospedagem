using desafio_poo.Models;

Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia("123456", "Nokia", "123456", 32);
nokia.Ligar();

nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("789456123", "Iphone", "456789456", 64);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

