using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("===Teste Nokia===");
Smartphone nokia = new Nokia(numero:"123456", modelo: "modelo 1", imei:"111111111", memoria: "64");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("===Teste Iphone===");
Smartphone iphone = new Iphone (numero:"789789", modelo: "modelo 2", imei:"222222222", memoria: "128");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");