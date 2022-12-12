using MasAcercaDeTiposDeDatos;

string separador = "========================================";

Console.WriteLine(separador);

Console.WriteLine("To String");
var cantidad = 5; 

if(cantidad.ToString() == "5") //To.String para poder comparar una cadena tipo string
{
    Console.WriteLine("Son iguales");
}
else 
{
    Console.WriteLine("No son iguales");
}

Console.WriteLine(separador);

var hoy = DateTime.Today.ToString("yyyyy-MM-dd (dddd)");
Console.WriteLine(hoy);

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Parse y TryParse");

//Enteros
var cantidadString = "10";
int cantidad1 = int.Parse(cantidadString); //Conertir la cadena tipo String a un numero int

cantidad1++;
Console.WriteLine(cantidad1); // 6

//Decimal
var cantidadDecimalString = "9.9";
var cantidadDecimal = decimal.Parse(cantidadDecimalString);
cantidadDecimal++; 
Console.WriteLine(cantidadDecimal);

//Booleanos
var booleanoString = "true";
var booleano = bool.Parse(booleanoString);
if(booleano)
{
    Console.WriteLine("Convertimos de string a Booleano");
    Console.WriteLine(booleano);
}

//Fechas
var fechaStrign = "2022-08-03";
var fecha = DateTime.Parse(fechaStrign);

Console.WriteLine(fecha.AddYears(1)); //2022-08-02

//Error 
//var supuestoNumero = "Adrian"; //Indica que el valor "Adrian" no tiene el formato correcto
var supuestoNumero = "999"; //Al ser un numero si tiene el formato correcto y puede realizar las condicones correspondientes
//var numero = int.Parse(supuestoNumero);
int numero;
var pudoParsear = int.TryParse(supuestoNumero, out numero); //out permire modificar el valor de la variable desde la funcionalidad
if (pudoParsear)
{
    // Lugar seguro donde se puede usar la variable numero
    numero++;
    Console.WriteLine(numero);
}
else
{
    Console.WriteLine($"El valor {supuestoNumero} no tiene el formato correcto.");
}



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Casteos");

//Ejemplo 1: Casteo explicito, de entero a double
var cantidad11 = 7;
var cantidad22 = 4;

var division = (double)cantidad11 / cantidad22; //(double) permite castear la variable cantidad11, permitiendo convertir un int a double y poder realizar la divison double
Console.WriteLine("La division es " + division);

//Ejemplo 2: Otro casteo explicito 
byte byte1; //0 hasta 255
int int1 = 3; // +- -2 mil millones hasta +- 2 mil millones

byte1 = (byte)int1;

Console.WriteLine(byte1);

// Ejemplo 3: Casteo implicito

byte byte2 = 11;
int int2;

int2 = byte2;  // Casteo implicito, ya que se casteo la variable byte en el int

Console.WriteLine(int2);


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Enums"); //Enum es un valor especial que nos permite agrupar un conjunto de constantes numericas


var statusDeLaVentaDeUnaCamisa = StatusVenta.PendienteDePago;
switch (statusDeLaVentaDeUnaCamisa)
{
    case StatusVenta.Exitoso:
        Console.WriteLine("La venta fue exitosa");
        break;
    case StatusVenta.PendienteDePago:
        Console.WriteLine("El cliente debe de pagar");
        break;
    case StatusVenta.Cancelada:
        Console.WriteLine("La venta fue cancelada");
        break;
    default:
        Console.WriteLine("Staus Desconocido");
        break;
}

//Ejemplo 2: Casteos

int status = (int)statusDeLaVentaDeUnaCamisa;
Console.WriteLine(status); // 1

int status3 = 3;
var status3Nombre = (StatusVenta)status3;
Console.WriteLine(status3Nombre);


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Arreglos");

char[]? vocales = new char[5]; // ? Se indica para indicar que vocales puede ser nulo
//vocales = null; // Son tipo de referencia

vocales[0] = 'a';
vocales[1] = 'e';
vocales[2] = 'i';
vocales[3] = 'o';
vocales[4] = 'u';

var segundaVocal = vocales[1];
Console.WriteLine(segundaVocal);
Console.WriteLine(separador);
foreach (var vocal in vocales)
{
    Console.WriteLine(vocal);
}
Console.WriteLine(separador);
// Ejemplo 2: Arreglo de enteros
var primeros6Numeros = new int[] {1, 2, 3, 4 ,5 ,6};
foreach (var numero1 in primeros6Numeros)
{ 
    Console.WriteLine($"{numero1}"); 
}

Console.WriteLine(separador);

Console.WriteLine(separador);
Console.WriteLine("Arreglos - Indices");

var vocales2 = new char[] {'a', 'e', 'i', 'o', 'u'};

var segundaVocal2 = vocales [1]; // e
var ultimaVocal = vocales2 [^1]; // u

Index penultimo = ^2;
var penultimaVocal = vocales [penultimo]; // o
Console.WriteLine(penultimaVocal);


Console.WriteLine(separador);
Console.WriteLine("Arreglos - Rangos");

Range dosPrimeros = ..2;
var dosPrimerasVocales = vocales[dosPrimeros]; // 0 , 1 
//var dosPrimerasVocales = vocales[..2]; // 0 , 1 
var tresPrimerasVocales = vocales2[..3];

var dosUltimasVocales = vocales[^2..]; // ^2, ^1

var tresEnMedio = vocales[1..4]; //1,2,3
var tresEnMedioV2 = vocales[1..^1]; //1,2,3

foreach (var local in tresEnMedioV2)
{
    Console.WriteLine(local);
}

Console.WriteLine(separador);
Console.WriteLine("Arreglos - Multidimensionales");

int[,] matriz = new int[2, 2];
Console.WriteLine(matriz.Rank); // 2

matriz[0, 0] = 1; // Primera fila, primera columna
matriz[0, 1] = 2; // Primera fila, segunda columna
matriz[1, 0] = 3; // Segunda fila, primera columna
matriz[1, 1] = 4; // Segunda fila, segunda columna

var elemento01 = matriz[1, 1]; // 4

int[,] matriz2 = new int[,]
{
    { 5, 6 }, //primera fila
    { 7, -5 }, //segundo fila
    { 8, 9 }, //tercera fila
};

for (int fila = 0; fila < matriz2.GetLength(0); fila++)
{
    for (int columna = 0; columna < matriz2.GetLength(1); columna++)
    {
        Console.Write($" {matriz2[ fila, columna ] } ");
    }
    Console.WriteLine();

}


Console.WriteLine(separador);
Console.WriteLine("Arreglos - de arreglos");

int[][] arregloDeArreglos =
{
    new int [] {1, 2},
    new int [] {3, 4, 5},
    new int [] {6},
    new int [] {7, 8}
};

var segundoElemento = arregloDeArreglos[1]; // [3,4,5]

//foreach ( var valor in segundoElemento )
//{
//    Console.Write($"{valor}");
//}

//arregloDeArreglos[3] = new int[] { 9, 10, 11 };

//var tercerElemento = arregloDeArreglos[3];

//foreach (var valor in tercerElemento)
//{
//    Console.Write($"{valor}");
//}

for (int fila = 0; fila < arregloDeArreglos.Length; fila++)
{
    var arreglo = arregloDeArreglos[fila];
    for (int columna = 0; columna < arreglo.Length; columna++)
    {
        Console.WriteLine($"{arreglo[columna]}");
    }
    Console.WriteLine();
}

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Manipulando Strings");

var name = "Adrian";
var nameEnMayus = name.ToUpper(); // ADRIAN
var nameEnMinus = name.ToLower(); //adrian

var longitud = name.Length; //Longitud de la variable 

Console.WriteLine("¿Desea terminar el programa? (y/n)");
var entradaUsuario = Console.ReadLine();

if(entradaUsuario?.ToLower().Trim() == "y") //ToLower para convertir a minus, Trim() para ignorar espacios en blanco que el usuario ingreso
{
    Console.WriteLine("Terminando el programa");
} 
else
{
    Console.WriteLine("El programa no va a terminar");
}

var mensaje = "123Hola, ¿Como estas?87";
char[] numeros = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
var mensajeArreglado = mensaje.Trim(numeros);
Console.WriteLine(mensajeArreglado);

long monto1 = 123;
long monto2 = 4;
long monto3 = 123456789L;
long monto4 = 1234567890L;
Console.WriteLine(monto1.ToString().PadLeft(10, '0'));
Console.WriteLine(monto2.ToString().PadLeft(10, '0'));
Console.WriteLine(monto3.ToString().PadLeft(10, '0'));
Console.WriteLine(monto4.ToString().PadLeft(10, '0'));