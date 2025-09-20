
// TODO: Realizar os testes com as classes Nokia e Iphone

using Desafio_Celulares.Models;                                                                                                                

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111111-1", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone("4987", "Modelo 2", "12222222-2", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
