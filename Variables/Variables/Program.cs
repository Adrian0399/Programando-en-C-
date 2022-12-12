// See https://aka.ms/new-console-template for more information
string separador = "--------------------------------------------------------------------------------";

/* Costantes y Valores Magicos */
var cantida1 = 1;
cantida1 = 2;

#pragma warning disable CS0219 // La variable está asignada pero nunca se usa su valor
const int miConstante = 7;
#pragma warning restore CS0219 // La variable está asignada pero nunca se usa su valor
//Advertencia Ctrl + .

const double FactorConversionKilometrosPorHoraAMetrosPorSegundo = 3.6;

var velocidad = 100;
var velocidad2 = velocidad / FactorConversionKilometrosPorHoraAMetrosPorSegundo;
Console.WriteLine(velocidad2);




Console.WriteLine(separador);
/* Orden de precedencia de las Operaciones - Legibilidad */
var can1 = 1;
var can2 = 2;
var can3 = 3;

var can4 = can1 + can2 + can3;
Console.WriteLine(can1);

var can5 = can1 + can2 * can3;
Console.WriteLine(can5);

var can6 = (can1 + can2) * can4;
Console.WriteLine(can6);


Console.WriteLine(separador);
/* Operaciones de Asignacion */
var cantid1 = 7m; 
var cantid2 = 5m;

var sumaa = cantid1 + cantid2;

//Aqui se altera la cantidad1
//cantid1 += cantid2; //cantidad1 = cantidad1 + cantidad2
//Console.WriteLine("Cantidad1 es " + cantid1);

//cantid1 -= cantid2; // cantidad 1 = cantidad1 - cantidad2

//cantid1 *= cantid2; //cantidad1 = cantidad1 * cantidad2

//cantid1 /= cantid2; //cantidad1 = cantidad1 / cantidad2

//cantid1 %= cantid2; //cantidad1 = cantidad1 % cantidad2

//Console.WriteLine("Cantidad1 es " + cantid1);

var name2 = "Adrian";
var apellido2 = " Olvera";
name2 += apellido2; // nombre = nombre + apellido
Console.WriteLine(name2);


Console.WriteLine(separador);
/* Expresiones VOID */
var canti1 = 7;
var canti2 = 5;

var suma = canti1 + canti2;

// Console.WriteLine("text") + 1; 
// No todo en C# devuelve un valor


Console.WriteLine(separador);
/* Operaciones Unarias */

var cantidad5 = 7;

var cantidad1PorMenos1 = -cantidad5; // (-1) * cantidad1;

//Console.WriteLine(cantidad1PorMenos1);

cantidad5++; // Cantidad5 = cantidad5+1
//cantidad5--; 
//++cantidad5; Primero se realiza la operacion y despues se agrega la variable
//--cantidad5;

Console.WriteLine(cantidad5);






Console.WriteLine(separador);
/* Interpolación de String */
var cantidad9 = 7;
var cantidad8 = 4;
var resultado9 = cantidad9 + cantidad8;

Console.WriteLine("La suma de " + cantidad9 + " + " + cantidad8 + " = " + resultado9);
Console.WriteLine($"La suma de {cantidad9} + {cantidad8} = {resultado9}");

var name = "Adrian";
Console.WriteLine($"Mi nombre es: {name.ToUpper()} en Mayus");

Console.WriteLine(separador);
/*
Console.WriteLine(separador);
checked //Cheked para revisar las operaciones y lanzar un error en caso de overflow aritmetico
{
    var maximo = int.MaxValue;
    var sumaM = maximo + 1;

    Console.WriteLine(maximo);
    Console.WriteLine(sumaM);
}
*/

Console.WriteLine(separador);
/* Otras operaciones binarias */
var cant1 = 7.1m;
var cant2 = 4.3m;
var resulSuma = cant1 + cant2;
var resulResta = cant1 - cant2;
//var resulDivison = (double)cant1 / cant2; //(double) se hace un casteo para convertir el numero entero a double
var resulDivison = cant1 / cant2;
var resulMultiplicacion = cant1 * cant2;
var resulResiduo = cant1 % cant2;

Console.WriteLine(resulSuma);
Console.WriteLine(resulResta);
Console.WriteLine(resulDivison);    
Console.WriteLine(resulMultiplicacion);
Console.WriteLine(resulResiduo);


Console.WriteLine(separador);
/* Operaciones Binarias */
var cantidad1 = 5;
var cantidad2 = 10;
var resultado = cantidad1 + cantidad2;
Console.WriteLine("La suma de: " + cantidad1 + " + " + cantidad2 + " = " + resultado);

var nombre111 = "Adrian";
var apellido111 = "Olvera";
Console.WriteLine(nombre111 + apellido111);



Console.WriteLine(separador);
/* Valores por defecto */
int? edad = null;

Console.WriteLine("Valor por defecto de int: ");
Console.WriteLine(edad);

bool hoyEsDomingo11 = default;
Console.WriteLine("Valor por defecto de bool: ");
Console.WriteLine(hoyEsDomingo11);

decimal precio11 = default;
Console.WriteLine("Valor por defecto de decimal: ");
Console.WriteLine(precio11);

DateTime fecha11 = default;
Console.WriteLine("Valor por defecto de DateTime: ");
Console.WriteLine(fecha11);

string nombre11 = null;
Console.WriteLine("Valor por defecto de String: ");
Console.WriteLine(nombre11);


Console.WriteLine(separador);
/* Nombre de las variables*/

var edadDeFelipe = 99; // camelCase
var apellido = "Olvera";
var hoy = DateTime.Now;
var float1 = 1.9f;
var double1 = 1.9d;

int edad1;
edad1 = 23;



Console.WriteLine(separador);
/* Date Time */

DateTime ahora = DateTime.Now;
DateTime cumpleanios = new DateTime(1999, 08, 03);
DateTime mañana = DateTime.Now.AddDays(1);

Console.WriteLine("El dia es:");
Console.WriteLine(mañana.Day);

Console.WriteLine("El dia del año es:");
Console.WriteLine(mañana.DayOfYear);

Console.WriteLine("El dia de la semana es:");
Console.WriteLine(mañana.DayOfWeek);

Console.WriteLine(mañana.Day);
Console.WriteLine(cumpleanios);
Console.WriteLine(ahora);

Console.WriteLine(separador);
/* String Verbatim */
string carta = @"A quien pueda interesar

Estimado cliente, se vencio tu fecha limite de pago.

Att: El Boss";


Console.WriteLine(carta);

//string directorioDelArchivo = "C:\\Mis documentos\\Mi carpeta\\excel.xlsx";
string directorioDelArchivo = @"C:\Mis documentos\Mi carpeta\excel.xlsx";
Console.WriteLine(directorioDelArchivo);


Console.WriteLine(separador);
/* Char y String - Secuencia de escape  */
char primeraLetraDelABC = 'A'; //Char solo para un caracter
Console.WriteLine(primeraLetraDelABC);

string nombre = "Adrian"; // String para 2 o mas caracteres
string texto = "Olvera Ordoñez: 'Ing en Sistemas Computacionales'";
string texto2 = "Olvera Ordoñez: \"Ing en Sistemas Computacionales\" ";
Console.WriteLine(nombre + texto);

Console.WriteLine(separador);
/* Boolean */
bool soyAdrian = true;
bool dosMasDosEsCinco = false; 

if (soyAdrian == true)
{
    Console.WriteLine("Hello :3");
} else
{
    Console.WriteLine("Bye");
}


Console.WriteLine(separador);
/* numeros reales */
float altura = 180.123456789f; //Ocupa 4 bytes; Precision de 6 a 9 digitos
Console.WriteLine("La altura es " + altura);

double anchura = 45.123456789; //Ocupa 8 bytes; Precision de 15 a 17 digitos
Console.WriteLine("La anchura es: " + anchura);

decimal monto = 9.123456789123456789123456789m; //Ocupa 16 bytes; Precision de 28 a 29 digitos
Console.WriteLine("El monto es; " + monto);

Console.WriteLine(separador);
/* int, double */
double alturaEnCm;
alturaEnCm = 175.50;

int edadAdrian = 23;

Console.WriteLine(alturaEnCm);

Console.WriteLine("Adrian Olvera, tiene: " + 
    + edadAdrian + "años y mide :"
    + alturaEnCm + " cm");

//150_000_000 el "_" nos permite poder separar numeros grandes, como una ","
int distanciaAlSol = 150_000_000;
Console.WriteLine(distanciaAlSol);

int numeroSuperGrande = int.MaxValue;
Console.WriteLine(numeroSuperGrande);

//////////////
uint uint1 = 3_000_000_000; // 0 hasta mas o menos 4 mil millones

long long1 = 8_000_000_000_000; // -9,223,372,036,854,775,808 hasta 9,223,372,036,854,775,807
ulong ulong1 = 16_000_000_000_000; // 0 hasta 18,446,744,073,709,551,615

byte byte1 = 145; // 0 hasta 255
sbyte sbyte1 = 100; // -128 hasta 127

short short1 = 30_000; // -32,768 hasta 32,767
ushort ushort1 = 65_000; //0 hasta 65,535





