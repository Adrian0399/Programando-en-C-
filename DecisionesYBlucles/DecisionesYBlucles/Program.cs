string separador = "===========================================================";


Console.WriteLine(separador);
Console.WriteLine(" = Logica Booleana = ");
var cantidad1 = 5;
var cantidad2 = 5;

var cantidad1IgualACantidad2 = cantidad1 == cantidad2; // true
Console.WriteLine($"Son {cantidad1} y {cantidad2} iguales? {cantidad1IgualACantidad2} ");

var cantidad1EsDiferenteACantidad2 = cantidad1 != cantidad2; //false
Console.WriteLine($"Son {cantidad1} y {cantidad2} diferentes? {cantidad1EsDiferenteACantidad2} ");

var esCantidad1MenorQue10 = cantidad1 < 10; // true
var esCantidad1MayorQue10 = cantidad1 > 10; // false

var esCantidad1MenorOIgualQue10 = cantidad1 <= 10; //true
var esCantidad1MayorOIgualQue10 = cantidad1 >= 10; //true

var nombre1 = "Adrian";
var nombre2 = "Pedro";

var sonLosNombresIguales = nombre1 == nombre2; //false;

//var esNombre1Nulo = nombre1 == null; //false
var esNombre1Nulo = nombre1 is null; //false, se reemplaza == por un "is"

var esNombre1NoNulo = nombre1 is not null; //true
Console.WriteLine(separador);

Console.WriteLine(separador);
Console.WriteLine(" = Operadores Condicionales Booleanos = ");

var canti1 = 6;

var estaEntre5y10 = canti1 > 5 && canti1 < 10; // true
Console.WriteLine($"Esta el numero {canti1} entre 5 y 10? {estaEntre5y10}");

var canti11 = 35;

// true && true => true
// true && false => false
// false && true => false
// false && false => false
var estaEntre10y20 = canti11 > 10 && canti11 < 20; // false && Requiere que ambas o todas la condicones sean TRUE, si una sola falla seria FALSE
Console.WriteLine($"Esta el numero {canti11} entre 5 y 10? {estaEntre10y20}");

// true || true => true
// true || false => true
// false || true => true
// false || false => false
var cantidad1Es5o6 = canti1 == 5 || canti1 == 6; // || Solo requiere de que una condicion sea verdadera para ser TRUE, si ambas son verdaderas seria TRUE; de lo contrario que ninguna condición se cumpla seria FALSE
Console.WriteLine($"¿Es {canti1} igual a 5 o 6? {cantidad1Es5o6}");


string? apellido = "Olvera";

var estaElApellidoEnMayusculas = apellido == apellido.ToUpper();
Console.WriteLine("El apellido esta en Mayusculas? " + estaElApellidoEnMayusculas);


Console.WriteLine(separador);
Console.WriteLine("Condicional IF");


var cantidad11 = 3;
if (cantidad11 > 5) {
    Console.WriteLine("Es mayor a 5");
    Console.WriteLine("Procesando...");
} else if (cantidad11 == 3){
    Console.WriteLine("El valor es 3");
} else {
    Console.WriteLine("En menor o igual a 5");
}
Console.WriteLine("Fin");


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Operador ternario");

bool usuarioEstaLogueado = true;

//string mensajeBienvenida;

//if (usuarioEstaLogueado)
//{
//    mensajeBienvenida = "Bienvenido";
//} else
//{
//    mensajeBienvenida = "Logueate para comenzar";
//}

string mensajeBienvenida = usuarioEstaLogueado ? "Bienvenido" : "Logueate para comenzar";
// <condicion> ? <Si la condicion es true> : <Si la condicion es false>

Console.WriteLine(mensajeBienvenida);

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Sentencia Switch");

var lugar = 4;

//if (lugar == 1)
//{
//    Console.WriteLine("1er lugar");
//} 
//else if (lugar == 2)
//{
//    Console.WriteLine("2do lugar");
//}
//else if (lugar == 3)
//{
//    Console.WriteLine("3er lugar");
//}
//else
//{
//    Console.WriteLine("Mejor suerte para la proxima");
//}

//switch (lugar)
//{
//    case 1:
//        Console.WriteLine("1er lugar");
//        break;
//    case 2:
//        Console.WriteLine("2do lugar");
//        break;
//    case 3:
//        Console.WriteLine("3er lugar");
//        break;
//    case 4:
//    case 5: 
//        Console.WriteLine("Casi lo logras :D");
//        break;
//    default:
//        Console.WriteLine("Mejor suerte para la proxima");
//        break;
//}

//Forma abreviada del switch anterior
var mensaje = lugar switch
{
    1 => "1er lugar",
    2 => "2do lugar",
    3 => "3er lugar",
    4 or 5 => "Casi lo logras :D",
    _ => "Mejor suerte para la proxima" //Tener el caso por defecto para no tener un error.
};


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Patrones Relacionales");

var temperatura = 42;

var mensaje2 = temperatura switch
{
    37 => "No tienes ninguna condicion",
    > 37 => "Tienes fiebre",
    < 37 => "Puede que tengas baaja el azucar"
};

Console.WriteLine(mensaje2);

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Patrones Logicos");

//EJEMPLO 1: NOT
string? apellido2 = "Olvera";

if(apellido2 is not null)
{
    Console.WriteLine(apellido.ToUpper());
}
Console.WriteLine("Fin");


//EJEMPLO 2: AND
var temp = 40;

var mensaje3 = temp switch
{
    37 => "No tienes ninguna condicion",
    > 37 and < 39 => "Tienes fiebre",
    >= 39 and < 43 => "Debes de ir al medico",
    >= 43 => "omae wa mou shindeiru",
    < 37 => "Puede que tengas baja el azucar"
};

Console.WriteLine(mensaje3);

//EJEMPLO 3: OR

var hoy = DateTime.Today;
var estacion = hoy.Month switch
{
    3 or 4 or 5 => "Primavera",
    6 or 7 or 8 => "Verano",
    0 or 10 or 11 => "Otono",
    12 or 1 or 2 => "Invierno",
    _ => throw new ApplicationException("Mes incorrecto")
};
Console.WriteLine(estacion);


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Bucle While");

int contador = 1;

while(contador <= 10)
{
    Console.WriteLine(contador);
    contador++; // contador = contador + 1
}

var balance = 200m;
var interes = 1.07m;
var contadorInteres = 1;

while ( contadorInteres <= 20)
{
    balance *= interes;
    contadorInteres++;
}
Console.WriteLine(balance);

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Bucle Do-While");

int contador2 = 1;

do
{
    Console.WriteLine(contador2);
    contador2++;
}while (contador2 <= 10);
Console.WriteLine("Fin");

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Bucle For");

int contador3 = 1; //Inicializacion
while (contador3 > 10) //Condicion
{ // Bloque de codigo
    Console.WriteLine(contador3);
    contador3++; //Modificacion de la variable inicializada
}


for (int contador4 = 1; contador4 <=11; contador4++)
{
    Console.WriteLine(contador4);
}

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Bucle For-Each");

var name = "Adrian";

foreach(var letra in name)
{
    Console.WriteLine(letra);  //Recorre cada elemento del String
}


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Sentencias de saltos - Break y Continue");

for(int i=1; i <= 10; i++)
{
    if (1 == 5)
    {
        //break;
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("Fin");



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Bucle infinito");

//while (true)
//{
//    Console.WriteLine("Este bucle no se detiene.");
//}

//for (; ; )
//{
//    Console.WriteLine("Este bucle tampoco se detiene.");
//}

while (true)
{
    Console.WriteLine("Te damos la bienvenida a la calculadora de la suma con C#!");
    Console.Write("Escriba el primer digito: ");
    var entradaUsuario = Console.ReadLine();
    if (entradaUsuario is null)
    {
        Console.WriteLine("Error: vuelve a comenzar");
        continue;
    }
    var numero1 = decimal.Parse(entradaUsuario);

    Console.Write("Escriba el segundo numero: ");
    entradaUsuario = Console.ReadLine();

    if( entradaUsuario is null)
    {
        Console.WriteLine("Error: vuelve a comenzar");
        continue;
    }
    var numero2 = decimal.Parse(entradaUsuario);
    Console.WriteLine($"EL resultado de sumar {numero1} + {numero2} es {numero1 + numero2}");
    
    Console.Write("¿Desea sumar otra vez? (y/n) ");
    entradaUsuario = Console.ReadLine();

    if (entradaUsuario != "y")
    {
        break;
    }

}
Console.WriteLine("Adiooooos");