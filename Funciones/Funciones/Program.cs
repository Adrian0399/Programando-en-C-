string separador = "============================================";

//Ejemplo 1: Funciones Simples
string ObtenerNombre()
{
    return "Adrian Olvera";
}

var miNombre = ObtenerNombre();
Console.WriteLine(miNombre);

//Ejemplo 2: Funcion que no retorna nada


void ImprimirFechaYHotaActual()
{
    var fechaYHora = DateTime.Now;
    for (int i = 0; i < 3; i++)
    {
        var mensaje = $"Hoy es {fechaYHora.ToString("yyyy-MM-dd hh:mm:ss")}";
        Console.WriteLine(mensaje);
    }
}

ImprimirFechaYHotaActual();


//Ejemplo 2: Funcion que recibe un parametro

int Duplicar(int valor)
{
    return valor * 2;
}

var dobleDe5 = Duplicar(5); //10
var dobleDe3 = Duplicar(3); //6

//Ejemplo 3: una funcion que recibe dos parametros

int Sumar(int sumando1, int sumando2)
{
    return sumando1 + sumando2;
}
var suma = Sumar(1, 5); //6

//EJemplo 4: Orden de los parametros
void RepetirEnConsola(string mensaje, int veces)
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine(mensaje);
    }
}
//RepetirEnConsola("Fortnite", 3); //Se debe de respetar el orden de los parametros declarados en la funcion
RepetirEnConsola(mensaje: "Fortnite", veces: 3);
//RepetirEnConsola(veces: 3, mensaje: "Fortnite"); //Aqui se puede ignorar el orden, pero siempre indicando el nombre del parametro y su valor
//Lo mejor es respetar el orden y tener parametros nombrados


Console.WriteLine(separador);

void ImprimirEnConsola(string mensaje, bool enMayus = true) //Se añade un parametro opcional y no es necesario 
{
    if (enMayus)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}

var nombre = "Adrian Olvera";
ImprimirEnConsola(nombre);

Console.WriteLine(separador);
//Ejemplo 2: Usando constantes
const bool mayus1 = true;
void ImprimirEnConsola2(string mensaje, bool mayus = mayus1) 
{
    if (mayus)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}
ImprimirEnConsola2("Adrian Olvera");

Console.WriteLine(separador);
//Ejemplo 3: Usando Defaul

void ImprimirEnConsola3(string mensaje, bool mayus = default) 
{
    if (mayus)
    {
        mensaje = mensaje.ToUpper();
    }
    Console.WriteLine(mensaje);
}
ImprimirEnConsola3("Adrian Olvera");

Console.WriteLine(separador);
Console.WriteLine(separador);
//Ejemplo 1: Pasando un arrelgo normal

double Promedio(int[] numeros)
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;
    }
    return suma / numeros.Length;
}
var promedio1 = Promedio(new int[] {1, 5, 9, 10, 10, 4 });
Console.WriteLine("Promedio: " + promedio1);


//Ejemplo 2: pasando un arreglo usando params

double Promedio2(params int[] numeros)
{
    var suma = 0.0;
    foreach (var numero in numeros)
    {
        suma += numero;
    }
    return suma / numeros.Length;
}
var promedio2 = Promedio2(1, 5, 9, 10, 10, 4);
Console.WriteLine("Promedio2: " + promedio2);

Console.WriteLine(separador);
Console.WriteLine(separador);
//Ejemplo 1: Usando Ref para tipos de valor

int cantidad = 5; 
void Duplicar2(ref int n)
{
    n *= 2;
    Console.WriteLine("El valor dentro de la funcion es: " + n);
}
Console.WriteLine("El valor fuera de la funcion es: " + cantidad);
Duplicar2(ref cantidad);
Console.WriteLine("El valor fuera de la funcion es: " + cantidad);


//Ejemplo 2: Tipos de refencia

var numeros = new int[] { 1, 2, 3 };
void DuplicarArreglo(int[] numeros)
{
    for (int i = 0; i < numeros.Length; i++)
    {
        numeros[i] *= 2;
    }
}
void ImprimirArreglo(int[] numeros)
{
    foreach (var numero in numeros)
    {
        Console.Write($"{numero}");
    }
}

Console.Write("Valores del arreglo antes de la duplicacion: ");
ImprimirArreglo(numeros);

Console.WriteLine();

DuplicarArreglo(numeros);

Console.Write("Valores del arreglo despues de la duplicacion: ");
ImprimirArreglo(numeros);


//Ejemplo 3: Y los Strings? 

void PonerEnMayus (string nombre)
{
    nombre = nombre.ToUpper(); //Esto lo que crea es un nuevo String
    Console.WriteLine("El valor dentro de la funcion es: " + nombre);
}
var nombre9 = "Adrian";
Console.WriteLine("El valor fuera de la funcion es: " + nombre9);
PonerEnMayus(nombre9);
Console.WriteLine("El valor fuera de la funcion es: " + nombre9);


Console.WriteLine(separador);

//Ejemplo 1: un out
int cantidad8;
void DuplicarYTriplicar(int operando, out int resultadoDuplo, out int resultadoTriplo)
{
    resultadoDuplo = operando * 2;
    resultadoTriplo = operando * 3;
}
int resultadoDuplo, resultadoTriplo;

DuplicarYTriplicar(3, out resultadoDuplo, out resultadoTriplo);
Console.WriteLine("EL doble es: " + resultadoDuplo);
Console.WriteLine("EL triple es: " + resultadoTriplo);

Console.WriteLine(separador);
//Ejemplo 2: tryparse

int numero5;
string numeroString = "7";
//string numeroString = "Adrian";

if (int.TryParse(numeroString, out numero5))
{
    Console.WriteLine("El numero es: " + numero5);
} 
else
{
    Console.WriteLine("Formato incorrecto");
}


Console.WriteLine(separador);
//Ejemplo: Una simple Tupla

(int edad, int edad2, string nick) tupla = (99, 45, "Kabil57");
Console.WriteLine(tupla);
Console.WriteLine(tupla.edad);
Console.WriteLine(tupla.edad2);
Console.WriteLine(tupla.nick);

//EJemplo 2: devolviendo varios valores de una funcion

(int duplo, int triplo) DuplicarYTriplicar2(int valor)
{
    return (valor * 2, valor * 3);
}
var cantidad3 = 10;
var resultado3 = DuplicarYTriplicar2(cantidad3);

Console.WriteLine("La cantidad es: " + cantidad3);
Console.WriteLine("Su duplo es: " + resultado3.duplo);
Console.WriteLine("Su triplo es: " + resultado3.triplo);


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Funciones Locales");
void SumarEImprimir()
{
    var cantidad6 = 5;
    ImprimirValor(cantidad6);
    cantidad++;
    ImprimirValor(cantidad6);

    void ImprimirValor(int cantidad6)
    {
        Console.WriteLine("El valor es " + cantidad6);
    }
}

SumarEImprimir();

//Lambda

int Sumaar(int a, int b) => a + b;
int Restaa(int a, int b) => a - b;
int Division(int a, int b) => a / b;
int Multiplicacion(int a, int b) => a * b;


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Action"); // Es una funcion que no retorna nada

//Ejemplo 1:  Funcion void que no recibe parametros

Action imprimeMsj;
void ImprimirFechaAndHora()
{
    Console.WriteLine(DateTime.Now.ToString());
}

void ImprimirMiNombre()
{
    Console.WriteLine("Adrian Olvera");
}

imprimeMsj = ImprimirFechaAndHora;

imprimeMsj();

imprimeMsj = ImprimirMiNombre;
imprimeMsj();

void Procesar(Action action)
{
    Console.WriteLine("Antes de ejecutar el action");
    action();
    Console.WriteLine("Despues de ejecutar el action");
}
imprimeMsj = ImprimirFechaAndHora;
Procesar(imprimeMsj);
Console.WriteLine();
Procesar(ImprimirMiNombre);

Console.WriteLine(separador);
//Ejemplo 2: funcion void que recibe un parametro
Action<int> alterarNumero;

void Sumar1(int valor)
{
    valor++;
    Console.WriteLine("El valor + 1 es " + valor);
}
alterarNumero = Sumar1;
alterarNumero(5);

//Ejemplo 3: funcion void que recibe 2 parametros

Action<string, int> imprimirNVeces;
void Imprimir(string mensaje3, int veces)
{
    for (int i = 0; i < veces; i++)
    {
        Console.WriteLine(mensaje3);
    }
}
imprimirNVeces = Imprimir;
imprimirNVeces("Adrian", 10);



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Func"); // Funcion que retorna un string pero no recibe parametros

Func<string> retornaString;

string ObtenerFechaYHoraActual()
{
    return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
}

retornaString = ObtenerFechaYHoraActual;
var resultado = retornaString();    
Console.WriteLine(resultado); 

void Procesar1(Func<string> productoDeValor)
{
    Console.WriteLine("Linea Anterior");
    var valor = productoDeValor();
    Console.WriteLine("El valor es: " + valor);
    Console.WriteLine("Linea posterior");
}

Procesar1(retornaString);
Console.WriteLine();


//Ejemplo 2: Un Func que recibe parametros
Func<int, string> recibeEnteroRetornaString;
string ObtenerNombreDelMes(int mes)
{
    var fecha = new DateTime(2022, mes, 1);
    return fecha.ToString("MMMM");
}
recibeEnteroRetornaString = ObtenerNombreDelMes;
var mayo = recibeEnteroRetornaString(5);
Console.WriteLine(mayo);



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Predicados"); // Un predicado es un Func que siempre retorna un Booleano

bool EsPar(int n)
{
    return n % 2 == 0;
}

Predicate<int> predicado = EsPar;

var numero4 = 4;
Console.WriteLine($"¿Es {numero4} par? {predicado(numero4)}");
numero4 = 9;
Console.WriteLine($"¿Es {numero4} par? {predicado(numero4)}");

/*
Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Delegados"); // ActionFunc y Predicate son ejemplos de Delegados

bool TryParse2(string valor2, out int resul)
{
    return int.TryParse(valor2, out resul);
}
//Func<string, int, bool> tryParseFunc = TryParse2;
TryParseDelegado miTryParse = TryParse2;

int cantidaad;

if (miTryParse("12", out cantidaad))
{
    Console.WriteLine(cantidaad);
}

delegate bool TryParseDelegado(string valor, out int resultado);
*/



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Funciones Anonimas");
//Ejemplo 1: Una simple funcion anonima

Action imprimirMensaje = () =>
{
    Console.WriteLine(DateTime.Now.ToString());
};
imprimirMensaje();

//Ejemplo 2: Pasando una funcion anonima como parametro

void Processar(Action accion)
{
    Console.WriteLine("Antes de ejecutar la acicon");
    accion();
    Console.WriteLine("Despues de ejecutar la accion");
}

Processar(() =>
{
    Console.WriteLine(DateTime.Now.ToString());
});

//Ejemplo 3: Funcion anonima que recibe un parametro y retorna un valor

Func<int, int> duplicar = aa => 2 * aa;
var duplicarV2 = (int aa) => 2 * aa;

//Ejemplo 4: Funcion anonima que reciba 2 parametros y retorna un valor
Func<bool, string, int> ejemp = (bool1, string1) =>
{
    return 42;
};

var ejemploV2 = (bool bool1, string string1) =>
{
    return 42;
};

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Funcion Main");

Console.WriteLine($"Recibiendo {args.Length} argumentos de la consola");

foreach (var arg in args)
{
    Console.WriteLine(arg);
}