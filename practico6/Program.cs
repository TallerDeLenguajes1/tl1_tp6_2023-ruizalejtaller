// See https://aka.ms/new-console-template for more information

/*
Console.WriteLine("Hello, World!");

int a;
int b;

a=10;
b=a;

Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);


String str;
float num;

Console.WriteLine("Escriba un número: ");

str = Console.ReadLine();

bool anda = float.TryParse(str, out num);


if (anda)
{
    if (num>0)
    {
    Console.WriteLine("El inverso de: "+num+" es 1/"+num);
    } else Console.WriteLine(num+ " es menor que cero");
}

*/

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

    str = Console.ReadLine();

    bool anda = int.TryParse(str, out op);

    if (anda)
    {
        if (op>0 && op <=4)
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

