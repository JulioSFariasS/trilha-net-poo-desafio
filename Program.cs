using DesafioPOO.Models;

Smartphone nokia = new Nokia(numero:"40028922", modelo:"Modelo X",imei:"111111111",memoria:64);
nokia.ApresentarInformacoes();
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "22982004", modelo:"Modelo Y", imei:"222222222", memoria: 128);
iphone.ApresentarInformacoes();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("LinkedIn");