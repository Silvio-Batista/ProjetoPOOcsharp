using DesafioPOO.Models;
using ProjetoPOOcsharp.Models;
Console.Clear();

Smartphone nokia = new Nokia(numero: "111111", modelo: "modelo 1", imei: "aa11", memoria: 10);
Smartphone iphone = new Iphone(numero: "222222", modelo: "modelo 2", imei: "bb22", memoria: 20);

nokia.InstalarAplicativo("Telegram");
nokia.Ligar();
nokia.ReceberLigacao();
Console.WriteLine(nokia.Numero);
Console.WriteLine("-----------------------");
iphone.InstalarAplicativo("Instagram");
iphone.Ligar();
iphone.ReceberLigacao();
Console.WriteLine(iphone.Numero);