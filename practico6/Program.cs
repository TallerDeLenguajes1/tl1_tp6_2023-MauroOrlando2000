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



//CALCULADORA

double num1=0;
int num2;
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


//CALCULADORAV2

anda = false;
Console.WriteLine("\n\nCalculadora");
while(!anda)
{
    while(!anda || intNum < 1 || intNum > 6)
    {
        Console.WriteLine("Que desea hacer?\n1.Valor Absoluto\n2.Cuadrado de un número\n3.Raiz cuadrada\n4.Seno\n5.Coseno\n6.Entero de un número float");
        stringNum = Console.ReadLine();
        anda = int.TryParse(stringNum, out intNum);
        if(!anda || intNum < 1 || intNum > 6)
        {
            Console.WriteLine("Numero inválido\n");
        }
    }
    anda = false;

    while(!anda)
    {
        Console.WriteLine("Ingrese el número a operar");
        stringNum = Console.ReadLine();
        anda = double.TryParse(stringNum, out num1);
        if(!anda)
        {
            Console.WriteLine("Numero inválido\n");
        }
    }
    switch(intNum)
    {
        case 1: num1 = Math.Abs(num1);
                break;
        case 2: num1 *= num1;
                break;
        case 3: num1 = Math.Sqrt(num1);
                break;
        case 4: num1 = Math.Sin(num1);
                break;
        case 5: num1 = Math.Cos(num1);
                break;
        case 6: num1 = Convert.ToInt32(num1);
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

anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese el primer número");
    stringNum = Console.ReadLine();
    anda = double.TryParse(stringNum, out num1);
    if(!anda)
    {
        Console.WriteLine("Numero inválido\n");
    }
}

anda = false;
while(!anda)
{
    Console.WriteLine("Ingrese el segundo número");
    stringNum = Console.ReadLine();
    anda = int.TryParse(stringNum, out intNum);
    if(!anda)
    {
        Console.WriteLine("Numero inválido\n");
    }
}

if(intNum > num1)
{
    Console.WriteLine("El número mayor es "+intNum);
    Console.WriteLine("El número menor es "+num1);
}
else
{
    Console.WriteLine("El número mayor es "+num1);
    Console.WriteLine("El número menor es "+intNum);
}


//EJERCICIO 4

string? cadenaUno = null, cadenaDos = null;
anda = false;

Console.WriteLine("Ingrese una cadena de caracteres");
while(!anda)
{
    cadenaUno = Console.ReadLine();
    if(cadenaUno == null)
    {
        Console.WriteLine("No puede ser una cadena nula");
    }
    else
    {
        anda = true;
    }
}

Console.WriteLine($"La longitud de la cadena es {cadenaUno.Length}");

Console.WriteLine("Ingrese una segunda cadena de caracteres");
anda = false;
while(!anda)
{
    cadenaDos = Console.ReadLine();
    if(cadenaDos == null)
    {
        Console.WriteLine("No puede ser una cadena nula");
    }
    else
    {
        anda = true;
    }
}

Console.WriteLine("Cadenas concatenadas: " + cadenaUno + " " + cadenaDos);

Console.WriteLine($"Subcadena extraida: " + cadenaUno.Substring(5));

anda = false;
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
            Console.WriteLine($"La suma de {num1-num2} y {num2} es {num1}");
            break;
    case 2: num1 -= num2;
            Console.WriteLine($"La resta de {num1+num2} y {num2} es {num1}");
            break;
    case 3: num1 *= num2;
            Console.WriteLine($"La multiplicación de {num1/num2} y {num2} es {num1}");
            break;
    case 4: num1 /= num2;
            Console.WriteLine($"La división de {num1*num2} y {num2} es {num1}");
            break;
}

foreach(char i in cadenaUno)
{
    Console.WriteLine(i);
}

Console.WriteLine("Ingrese una palabra a buscar en la cadena");
anda = false;
while(!anda)
{
    cadenaDos = Console.ReadLine();
    if(cadenaDos == null)
    {
        Console.WriteLine("No puede ser una cadena nula");
    }
    else
    {
        anda = true;
    }
}

if(cadenaUno.IndexOf(cadenaDos) != -1)
{
    Console.WriteLine($"La palabra \"{cadenaDos}\" se encuentra en \"{cadenaUno}\" en la posición {cadenaUno.IndexOf(cadenaDos)}");
}
else
{
    Console.WriteLine("Coincidencia no encontrada");
}

Console.WriteLine($"Cadena en mayusculas: {cadenaUno.ToUpper()}");
Console.WriteLine($"Cadena en minusculas: {cadenaUno.ToLower()}");