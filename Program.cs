using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Nokia n1 = new Nokia("25", "NokiaGalaxy", "123456", 64);

Iphone i1 = new Iphone("10", "Iphone6s", "78910", 32);

n1.Ligar();
i1.Ligar();

n1.InstalarAplicativo("Angry birds");
i1.InstalarAplicativo("Instagram");

n1.ReceberLigacao();
i1.ReceberLigacao();