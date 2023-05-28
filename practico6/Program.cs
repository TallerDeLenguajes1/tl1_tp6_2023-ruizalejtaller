// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

String str1, str2;
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


String str, rcad ="";
float num_a, num_b;
double resul = 0;
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
                    case 1: resul = suma(num_a, num_b);
                        rcad = $"La suma de {num_a} y {num_b} es igual a: ";
                        break;

                    case 2: resul = resta(num_a, num_b);
                        rcad = $"La diferencia entre {num_a} y {num_b} es igual a: ";
                        break;

                    case 3: resul = multiplica(num_a, num_b);
                        rcad = $"El producto entre {num_a} y {num_b} es igual a: ";
                        break;

                    case 4: resul = divide(num_a, num_b);
                        rcad = $"La división de {num_a} entre {num_b} es igual a: ";
                        break;

                    case 11: resul = max(num_a, num_b);
                        rcad = $"El maximo entre {num_a} y {num_b} es: ";
                        break;

                    case 12: resul = min(num_a, num_b);
                        rcad = $"El minimo entre {num_a} y {num_b} es: ";
                    break;
            
                }
                Console.WriteLine($"{rcad}{resul}");
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
                    case 5: resul = vabs(num_a);
                    break;

                    case 6: resul = cuadrado(num_a);
                    break;

                    case 7: resul = raiz(num_a);
                    break;

                    case 8: resul = seno(num_a);
                    break;

                    case 9: resul = coseno(num_a);
                    break;

                    case 10: resul = entera(num_a);
                    break;

                }
                Console.WriteLine($"Resultado: {resul}");
            }
        }

    }
    Console.WriteLine("\nDesea realizar otro calculo? (n) para no");

    str = Console.ReadLine();

    if (str == "n")
    {
        flag = false;
    }
}

Console.WriteLine("Ingrese la primer cadena de texto: ");
str1 = Console.ReadLine();

Console.WriteLine("La longitud de la primer cadena es {0}\n", str1.Length);

Console.WriteLine("Ingrese la segunda cadena de texto: ");
str2 = Console.ReadLine();

str = $"{str1} {str2}";

Console.WriteLine("\nConcatenadas:");
Console.WriteLine(str);

if (str.Length > 2) {
    Console.WriteLine("\nUna subcadena: ");
    Console.WriteLine($"{str.Substring(0,2)}");
}

foreach (char c in str)
{
    Console.WriteLine($"{c}");
}

Console.WriteLine("Ingrese subcadena a buscar: ");
str1 = Console.ReadLine();

if(str.Contains(str1))
{
    Console.WriteLine("La subcadena es parte de la cadena");
} else Console.WriteLine("La subcadena no pertenece a la cadena");

Console.WriteLine("\nLa cadena en mayusculas:");
Console.WriteLine(str.ToUpper());

Console.WriteLine("\nLa cadena en minisculas: ");
Console.WriteLine(str.ToLower());

Console.WriteLine("\nIngrese una cadena de caracteres separadas por .");
str = Console.ReadLine();

string[] separ = str.Split('.');

foreach (var sep in separ)
{
    Console.WriteLine($"{sep}");
}

Console.WriteLine("\nIngrese una ecuacion simple (+, -, * o /): ");
str = Console.ReadLine();

if (str.Contains("+"))
{
    separ = str.Split('+');

    bool ok1 = float.TryParse(separ[0], out num_a);
    bool ok2 = float.TryParse(separ[1], out num_b);

    if (ok1 && ok2)
    {
        Console.WriteLine($"La suma de {num_a} y {num_b} es igual a: {suma(num_a, num_b)}");
    }
}

if (str.Contains("-"))
{
    separ = str.Split('-');

    bool ok1 = float.TryParse(separ[0], out num_a);
    bool ok2 = float.TryParse(separ[1], out num_b);

    if (ok1 && ok2)
    {
        Console.WriteLine($"La diferencia entre {num_a} y {num_b} es igual a: {resta(num_a, num_b)}");
    }
}

if (str.Contains("*"))
{
    separ = str.Split('*');

    bool ok1 = float.TryParse(separ[0], out num_a);
    bool ok2 = float.TryParse(separ[1], out num_b);

    if (ok1 && ok2)
    {
        Console.WriteLine($"El producto de {num_a} y {num_b} es igual a: {multiplica(num_a, num_b)}");
    }
}

if (str.Contains("/"))
{
    separ = str.Split('/');

    bool ok1 = float.TryParse(separ[0], out num_a);
    bool ok2 = float.TryParse(separ[1], out num_b);

    if (ok1 && ok2)
    {
        Console.WriteLine($"La division de {num_a} entre {num_b} es igual a: {divide(num_a, num_b)}");
    }
}


double suma(float a, float b)
{

    return a+b;
}

double resta(float a, float b)
{
    return a-b;
}

double multiplica(float a, float b)
{
    return a*b;
}

double divide(float a, float b)
{
    return a/b;
}

double vabs(float a)
{
    return Math.Abs(a);
}

double cuadrado(float a)
{
    return a*a;
}

double raiz(float a)
{
    return Math.Sqrt(a);
}

double seno(float a)
{
    return Math.Sin(a);
}

double coseno(float a)
{
    return Math.Cos(a);
}

double entera(float a)
{
    return Math.Truncate(a);
}

double max(float a, float b)
{
    return Math.Max(a,b);
}

double min(float a, float b)
{
    return Math.Min(a,b);
}

