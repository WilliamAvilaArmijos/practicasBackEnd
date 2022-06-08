using Calc;
double val1, val2;

Calc<double> calc = new Calc<double>();
Console.WriteLine("Ingrese un numero");
val1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese un numero");
val2 = double.Parse(Console.ReadLine());
double sum = calc.Suma(val1, val2);
double res = calc.Resta(val1, val2);
double mul = calc.Multiplicacion(val1, val2);
double div = calc.Division(val1, val2);
Console.WriteLine("La suma de "+ val1 + "+" + val2 +" es: " +sum);
Console.WriteLine("La resta de " + val1 + "-" + val2 + " es: " + res);
Console.WriteLine("La multiplicacion de " + val1 + "*" + val2 + " es: " + mul);
Console.WriteLine("La division de " + val1 + "/" + val2 + " es: " + div);