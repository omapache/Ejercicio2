Console.WriteLine("Multiplicacion rusa");
int operacion = 0;
Console.WriteLine("Ingrese el multiplicador");
int multiplicador = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el multiplicando");
int multiplicando = Convert.ToInt32(Console.ReadLine());

while (1 < multiplicador)
{
    if (multiplicador % 2 != 0)
    {
        operacion += multiplicando;
    }
    multiplicando *= 2;
    multiplicador /= 2;
}
operacion += multiplicando;
Console.WriteLine("el resultado de la multiplicacion rusa es: " + operacion);
