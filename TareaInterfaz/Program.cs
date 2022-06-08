
using TareaInterfaz;

Console.WriteLine("Transportes");
Avion avion = new Avion();
Carro carro = new Carro();  
Moto moto = new Moto();
Bote bote = new Bote();
avion.despegar();
avion.acelerar();
avion.girar();
avion.frenar();
avion.aterrizar();
carro.acelerar();
carro.girar();
carro.frenar();
moto.acelerar();
moto.girar();
moto.frenar();
bote.Acelerar('10', '12');

