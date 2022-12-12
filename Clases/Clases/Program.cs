
using Clases;

Persona3.Procesar(null!);

/*
//Ejemplo 1: Uso Simple (Operador de Coalescnecia Nula ??)
int[]? numeros = new int[] { 1, 2 };

//numeros = null;

var conteo = numeros?.Length ?? 0;
//Ejemplo 2: Cambiando el valor de una variable

numeros ??= new int[] { };
Console.WriteLine($"Es nulo? {numeros is null}");
Console.WriteLine($"Es un arreglo vacio? {numeros?.Length == 0}");



/*
int[]? numeros = { 1, 2 };

Console.WriteLine($"La longitus es: {numeros?.Length}");




/*
var clase = new ClaseConPropiedadesInmutables()
{
    Propiedad1 = 42,
    Propiedad2 = "Adrian",
    Propiedad3 = true
};






/*
var empresa1 = new Empresa("Udemy", 2010);

var (nombre, año) = empresa1;
Console.WriteLine("Nombre de la empresa: " + nombre);
Console.WriteLine("Año de fundacion: " + año);

var empresa2 = empresa1 with { AñoFundacion = 2016 };
Console.WriteLine("Empresa 1: " + empresa1);
Console.WriteLine("Empresa 2: " + empresa2);

/*
var persona1 = new Personaa("Adrian", "Olvera");
var persona2 = new Personaa("Adrian", "Olvera");
var sonIguales = persona1 == persona2; //true

Console.WriteLine("¿Son los records iguales? " + sonIguales);
//Es un tipo de referencia
persona1 = null;

/*
var carro = new Carro();

carro = null;
var puntoA = new Punto(3, 4);

//error
//puntoA = null;

//Esto es valido
var puntoB = new Punto();

Console.WriteLine($"La distancia entre el Punto A y el Punto B es: {puntoA.Distancia(puntoB)}");

/*
//Clase normal 
var carro = new Carro() { Marca = "Toyota", Año = 2005 };

//Tipo anonimo (Clase sin nombre)
var persona = new { Nombre = "Adrian", Apellido = "Olvera", Edad = 23 };
Console.WriteLine(persona.Nombre);
Console.WriteLine(persona);

//Yo no puedo editar las propiedades de un tipo anonimo 
//persona.Nombre = "Adrian";

//Ejemplo: inferir nombres de propiedades
var miVariable = "Un Valor";
var carroAnonimo = new { carro.Marca, carro.Año, miVariable };
Console.WriteLine("Carro anonimo" + carroAnonimo);

//Ejemplo : Mutacion no destructiva
var personaMutada = persona with { Apellido = "Fernandez" ,Edad = 50 };
Console.WriteLine("Persona mutada" + personaMutada);


//Ejemplo 1: Patron simple
/*
if (apellido is { Length : 7})
{
    Console.WriteLine("La longitud del string es 7");
} else if (apellido is { Length: > 7 })
{
    Console.WriteLine("La longitud es mayor que 7");
}

if (apellido.Length == 7)
{

}else if (apellido.Length > 7)
{

}

//Ejemplo 2: Patron con varias propiedades

var carro = new Carro("Sonic");
carro.Año = 2022;

if (carro is { Marca: "Sonic" or "Chevrolet", Año: > 2010 })
{
    Console.WriteLine("Es un carrazo");
}
else if (carro is { Marca: "Mercedes", Velocidad: > 25 })
{
    Console.WriteLine("Bonito Mercedes");
}
else if (carro is { Año: < 2000 })
{
    Console.WriteLine("Te ha durado esa maquina");
}


switch (carro)
{
    case
    { Marca: "Sonic" or "Chevrolet", Año: > 2010 }:
        Console.WriteLine("Es un carrazo");
        break;
    case
    { Marca: "Mercedes", Velocidad: > 25 }:
        Console.WriteLine("Bonito Mercedes");
        break;
    case
    { Año: < 2000 }:
        Console.WriteLine("Te ha durado esa maquina");
        break;
}


//Ejemplo 3: Propiedades de propiedades

if (carro is { Marca.Length: > 6})
{
    Console.WriteLine("Es un carro con un nombre largo");
} 
else
{
    Console.WriteLine("Es un carro con un nomre corto");
}
*/

/*
string? mensaje = null;


//Usando metodo de extension
var cantidadPalabras = mensaje.ContarPalabras();
Console.WriteLine("Cantidad de palabras" + cantidadPalabras);

//Sin usar metodo de extension
//var cantidadPalabras_V2 = ExtensionesString.ContarPalabras(mensaje);
//Console.WriteLine("Cantidad de palabras" + cantidadPalabras_V2);




/*
//var carro1 = new Carro();
//var carro2 = new Carro();
//var carro3 = new Carro();
//var carro4 = new Carro();

//Console.WriteLine();

//Console.WriteLine($"Han sido instanciados {Carro.ConteoInstancias} carros");

//var conteo = carro1.ConteoInstancias;

var (valor, duplo, triplo) = Calculadora.CalcularDuplotriplo(10);
Console.WriteLine("El duplo es: " + duplo);

/*
var calculadora = new Calculadora();

var resultadoDT = calculadora.CalcularDuplotriplo(5);

//Ejemplo 0 sin deconstructor

//var valor = resultadoDT.Valor;
//var duplo = resultadoDT.Duplo;
//var triplo = resultadoDT.Triplo;

//Ejemplo 1: Explicita

//int valor, duplo, triplo;
//resultadoDT.Deconstruct(out valor, out duplo, out triplo); 

//Ejemplo 2: Forma resumida con Deconstruct

//resultadoDT.Deconstruct(out var valor, out var duplo, out var triplo);

//Ejemplo 3: Sin unsar Deconstruct directamente
//(var valor, var duplo, var triplo) = resultadoDT;

//Ejemplo 4: Lo mas resumido posible
var (valor, duplo, triplo) = resultadoDT;

Console.WriteLine("El valor es: " + valor);
Console.WriteLine("El duplo es: " + duplo);
Console.WriteLine("El triplo es: " + triplo);


/*
var carro1 = new Carro("Urus");
Console.WriteLine(carro1.Marca);

Console.WriteLine("===========");

var carro2 = new Carro();
Console.WriteLine(carro2.Marca);
*/


/*
var carro1 = new Carro();
carro1.Marca = "Chevrolet";
carro1.Año = 2022;
//carro1.Velocidad = 240;

Console.WriteLine($"{carro1.NombreComercial} velocidad = {carro1.Velocidad}");

//carro1.Acelerar();
carro1.Detener();

Console.WriteLine($"{carro1.NombreComercial} velocidad = {carro1.Velocidad}");
*/

/*
var carro2 = new Carro();
carro2.Marca = "Toyota";
carro2.Año = 2023;
ModificarMarca(carro2);
Console.WriteLine(carro2.Marca + " " +  carro2.Año);

//Es un tipo de refencia
carro2 = null;

void ModificarMarca (Carro carro)
{
    carro.Marca += "2";
}
*/