using DesafioPOO.Models;

Nokia TelNokia = new Nokia("Nokia123", "ModeloNokia", "ImeiNokia", 20);

TelNokia.Ligar();
TelNokia.ReceberLigacao();
TelNokia.InstalarAplicativo("WhatsApp");

Iphone TelIphone = new Iphone("Iphone123", "ModeloIphone", "ImeiIphone", 35);

TelIphone.Ligar();
TelIphone.ReceberLigacao();
TelIphone.InstalarAplicativo("Instagram");