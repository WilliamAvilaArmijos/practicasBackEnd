using PracticaInterfaz;

   
Console.WriteLine("Movimiento");
Persona persona = new Persona();
Animal animal = new Animal();

for (int i = 0; i < 100; i++)
{
    persona.correr();
    animal.correr();
}
