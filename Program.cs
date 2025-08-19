using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero: "111243", modelo: "modelo 1",imei: "11111111", memoria: 8);
Console.WriteLine("\n**** Nokia ****");
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

nokia.ReceberLigacao();

Console.WriteLine("\n**** Iphone ****");
Smartphone iphone = new Iphone(numero: "224124", modelo: "modelo 2",imei: "2222222", memoria: 16);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");

iphone.ReceberLigacao();