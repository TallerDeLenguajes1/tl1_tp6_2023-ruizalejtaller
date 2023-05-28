// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

String str1;
int num, inv=0, aux;

Console.WriteLine("Escriba un número entero: ");

str1 = Console.ReadLine();

bool ok = int.TryParse(str1, out num);


if (ok)
{
    if (num>0)
    {
        aux = num;

        while (aux>0)
        {
            inv = inv*10 + aux%10;
            aux /= 10;
        }

        Console.WriteLine("El inverso de: "+num+" es " + inv);
    } else Console.WriteLine(num+ " es menor que cero");
} else Console.WriteLine("No ingresó un número entero.");


String str;
float num_a, num_b;
int op;

bool flag = true;


while (flag)
{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Valor absoluto");
    Console.WriteLine("6. Cuadrado");
    Console.WriteLine("7. Raíz cuadrada");
    Console.WriteLine("8. Seno");
    Console.WriteLine("9. Coseno");
    Console.WriteLine("10. Parte entera");
    Console.WriteLine("11. Max entre 2 numeros");
    Console.WriteLine("12. Min entre 2 numeros");

    str = Console.ReadLine();

    bool anda = int.TryParse(str, out op);

    if (anda)
    {
        if (op>0 && op <=4 || op == 11 || op == 12)
        {
            Console.WriteLine("Ingrese el numero a: ");
            str = Console.ReadLine();
            bool anda1 = float.TryParse(str, out num_a);
            Console.WriteLine("Ingrese el numero b: ");
            str = Console.ReadLine();
            bool anda2 = float.TryParse(str, out num_b);

            if (anda1 && anda2)
            {
                switch (op)
                {
                    case 1: suma(num_a, num_b);
                    break;

                    case 2: resta(num_a, num_b);
                    break;

                    case 3: multiplica(num_a, num_b);
                    break;

                    case 4: divide(num_a, num_b);
                    break;

                    case 11: max(num_a, num_b);
                    break;

                    case 12: min(num_a, num_b);
                    break;
            
                }
            }
        }

        if (op>=5 && op <=10)
        {
            Console.WriteLine("Ingrese el numero: ");
            str = Console.ReadLine();
            bool anda1 = float.TryParse(str, out num_a);
        
            if (anda1)
            {
                switch(op)
                {
                    case 5: vabs(num_a);
                    break;

                    case 6: cuadrado(num_a);
                    break;

                    case 7: raiz(num_a);
                    break;

                    case 8: seno(num_a);
                    break;

                    case 9: coseno(num_a);
                    break;

                    case 10: entera(num_a);
                    break;

                }
            }
        }

    }
    Console.WriteLine("\nDesea realizar otro calculo? (n) para no");

    str = Console.ReadLine();

    if (str == "n")
    {
        Console.WriteLine("Saliendo..");
        flag = false;
    }
}

void suma(float a, float b)
{

    Console.WriteLine("\nLa suma de "+a+" + "+b+" es = "+(a+b));
}

void resta(float a, float b)
{
    Console.WriteLine("\n"+a+" - "+b+" es = "+(a-b));
}

void multiplica(float a, float b)
{
    Console.WriteLine("\n"+a+" multiplicado por "+b+" es = "+(a*b));
}

void divide(float a, float b)
{
    Console.WriteLine("\n"+a+" divido en "+b+" es = "+(a/b));
}

void vabs(float a)
{
    Console.WriteLine("\nEl valor absoluto de "+a+" es +"+Math.Abs(a));
}

void cuadrado(float a)
{
    Console.WriteLine("\nEl cuadrado de "+a+" es +"+(a*a));
}

void raiz(float a)
{
    Console.WriteLine("\nLa raíz cuadrada de "+a+" es +"+Math.Sqrt(a));
}

void seno(float a)
{
    Console.WriteLine("\nEl seno de "+a+" es +"+Math.Sin(a));
}

void coseno(float a)
{
    Console.WriteLine("\nEl coseno de "+a+" es +"+Math.Cos(a));
}

void entera(float a)
{
    Console.WriteLine("\nLa parte entera de "+a+" es +"+Math.Truncate(a));
}

void max(float a, float b)
{
    Console.WriteLine("\nEl maximo entre "+a+" y "+b+" es "+Math.Max(a,b));
}

void min(float a, float b)
{
    Console.WriteLine("\nEl minimo entre "+a+" y "+b+" es "+Math.Min(a,b));
}

