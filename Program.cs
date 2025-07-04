using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone 
Console.WriteLine("Sistema nokia");
Nokia nokia = new Nokia(numero: "123456", model: "NOKIA 2280", imei: "1258963", memory: 256);
nokia.Calling();
nokia.InstalApp("Whatsapp");
nokia.ReceiveCall();

Console.WriteLine("Sistema Iphone");
Iphone iphone = new Iphone(numero: "123456", model: "NOKIA 2280", imei: "1258963", memory: 256);
iphone.Calling();
iphone.InstalApp("Facebook");
iphone.ReceiveCall();