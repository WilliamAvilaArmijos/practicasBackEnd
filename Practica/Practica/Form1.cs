namespace Practica
{
    public partial class Form1 : Figura2d
    {
        private double radio;
        private double pi = 3.14;

        private void calcPeri()
        {
            perimetro = 2 * pi * radio;
        }

      
    }
}