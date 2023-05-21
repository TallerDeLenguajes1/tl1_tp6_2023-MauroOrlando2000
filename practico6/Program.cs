// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a: "+a);
Console.WriteLine("valor de b: "+b);


//EJERCICIO 1

int intNum = 1;
bool anda = false;
string? stringNum = "";

while(!anda || intNum < 1)
{
    Console.WriteLine("Ingrese un numero válido y mayor de 0");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out intNum);
    if(!anda)
    {
        Console.WriteLine("Numero inválido\n");
    }
    if(intNum < 1)
    {
        Console.WriteLine("Numero es menor a 0");
    }
}

int ceros=0, invertido=0, resto=0, aux;

aux = intNum;
for(int i=0; i<2; i++)
{
    while(aux != 0)
    {
        resto = aux % 10;
        aux = aux / 10;
        if(i==0)
        {
            ceros++;
        }
        else
        {
            for(int j=1; j<ceros; j++)
            {
                resto = resto * 10;
            }
            invertido += resto;
            ceros--;
        }
    }
    aux = intNum;
}

Console.WriteLine("El número original es "+intNum);
Console.WriteLine("El número invertido es "+invertido);



//EJERCICIO 2

int num1, num2;
anda = false;
Console.WriteLine("\n\nCalculadora V1");
while(!anda)
{
    while(!anda || intNum < 1 || intNum > 4)
    {
        Console.WriteLine("Que desea hacer?\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir");
        stringNum = Console.ReadLine();
        anda = int.TryParse(stringNum, out intNum);
        if(!anda || intNum < 1 || intNum > 4)
        {
            Console.WriteLine("Numero inválido\n");
        }
    }

    Console.WriteLine("Ingrese el primer número");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número");
    num2 = Convert.ToInt32(Console.ReadLine());
    switch(intNum)
    {
        case 1: num1 += num2;
                break;
        case 2: num1 -= num2;
                break;
        case 3: num1 *= num2;
                break;
        case 4: num1 /= num2;
                break;
    }
    Console.WriteLine("El resultado es " + num1 + "\n");
    Console.WriteLine("Desea realizar otra operacion? (1=Si, 0=No)");
    num2 = Convert.ToInt32(Console.ReadLine());
    if(num2 == 1)
    {
        anda = false;
    }
}