using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "58341111", modelo: "Modelo Nokia 10", imei: "1111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Netflix");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "58342222", modelo: "Modelo iPhone 15", imei: "2222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("HBO");
