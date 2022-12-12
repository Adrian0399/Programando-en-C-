

using GenericosYColecciones;

//Comparaciones personalizadas
var Adrian = new Persona { Nombre = "Adrian", Edad = 23 };
var Juana = new Persona { Nombre = "Juana", Edad = 25 };

var valor = Adrian.CompareTo(Juana); //1
Console.WriteLine(valor);

var personas = new List<Persona>()
{
    Juana,
    new Persona(){Nombre = "Roberto", Edad = 15},
    new Persona(){Nombre = "Lorena", Edad = 25},
    new Persona(){Nombre = "Mario", Edad = 22},
    Adrian,
    new Persona(){Nombre = "Esvetlana", Edad = 15}
};

personas.Sort();

Console.WriteLine("Ordenando por Edad: ");

foreach (var persona in personas)
{
    Console.WriteLine($"- {persona.Nombre} (Edad: {persona.Edad})");
}

//Ordenando por nombre
personas.Sort(new ComparadorPersonasPorNombre());

Console.WriteLine();
Console.WriteLine("Ordenando por Nombre: ");

foreach (var persona in personas)
{
    Console.WriteLine($"- {persona.Nombre} (Edad: {persona.Edad})");
}

/*
IEnumerable<int> conElValor2 = Sumar2(2).Take(30);
foreach (var valor in conElValor2)
{
    Console.WriteLine(valor);
}

IEnumerable<int> Sumar2(int valor)
{
    yield return valor;

    for (; ;)
    {
        valor += 2;
        yield return valor;
    }
}



/*
//Yield y ejecucion Diferida
var numeros = new List<int> { 1, 2, 3 };

var numerosCasteadosAEnumerable = numeros.AsEnumerable();

var enumerableDeNumeros = Primeros3Numeros();

//var primerNumero = enumerableDeNumeros.First();
var primerosDosElementos = enumerableDeNumeros.Take(2);

foreach (var valor in primerosDosElementos)
{
    Console.WriteLine(valor);
}

var todosLosNumeros = enumerableDeNumeros.ToList();

Console.WriteLine();

IEnumerable<int> Primeros3Numeros()
{
    yield return 1;
    yield return 2;
    yield return 3;
}


/*
//IEnumerable

var numeros = new List<int> { 1, 2, 3 };

ImprimirEnConsola(numeros);

string[] nombres = { "Adrian", "Pedro" };
ImprimirEnConsola(nombres);

void ImprimirEnConsola<T>(IEnumerable<T> valores)
{
    
    foreach (var valor in valores)
    {
        Console.WriteLine(valor);
    }
}






/*
//Diccionarios

Dictionary<string, int> diccionario = new Dictionary<string, int>();
diccionario.Add("Uno", 1); //Solamente agregar
diccionario["Dos"] = 2; //Agregar y modificar valores

var diccionario2 = new Dictionary<string, int>()
{
    {"Uno", 1 },
    {"Dos", 2 },
    {"Tres", 3 },
  
};

Console.WriteLine(diccionario["Dos"]);

//Console.WriteLine(diccionario["Tres"]);

if(diccionario.ContainsKey("Tres"))
{
    Console.WriteLine(diccionario["Tres"]);
}
else
{
    Console.WriteLine("La llave no fue encontrada");
}

//diccionario.Add("Uno", 1); /Da error porque ya existe esta key
diccionario["Uno"] = 10;
Console.WriteLine(diccionario["Uno"]);

foreach (var llave in diccionario.Keys)
{
    Console.WriteLine(llave);   
}
Console.WriteLine();
Console.WriteLine("Llaves:");
foreach (var llave in diccionario.Keys)
{
    Console.WriteLine(llave);
}

Console.WriteLine();
Console.WriteLine("Valores:");
foreach (var valor in diccionario.Keys)
{
    Console.WriteLine(valor);
}


var diccionarioParImpar = new Dictionary<string, List<int>>();
diccionarioParImpar.Add("par", new List<int>());
diccionarioParImpar.Add("impar", new List<int>());
for (int i = 1; i <= 10; i++)
{
    var llave = i % 2 == 0 ? "par": "impar";
    diccionarioParImpar[llave].Add(i);
}

foreach (var llaveValores in diccionarioParImpar)
{
    Console.WriteLine(llaveValores.Key);
    foreach (var valor in llaveValores.Value)
    {
        Console.WriteLine($"- {valor}");
    }
}

var pares = diccionarioParImpar["par"];
Console.WriteLine(pares.Count);
var impares = diccionarioParImpar["impar"];
Console.WriteLine(impares.Count);

/*
//Colecciones - Listado
int[] enteros = { 1, 2, 3 };

//enteros.Add(4);

List<int> enterosLista = new List<int>();
enterosLista.Add(1);
enterosLista.Add(5);
enterosLista.Add(15);

List<int> enterosLista2 = new() { 45, 1 , -2, 100, -50 };

enterosLista2.Add(-8);

var cantidad = enterosLista2.Count;

///enterosLista2[1] = 75;

//enterosLista2.Remove(15); 
//enterosLista2.RemoveAt(0); //Remover el objeto de un indice del arreglo

enterosLista2.Sort(); //Ordenar elementos de menor a mayor 

foreach(var elemento in enterosLista2)
{
    Console.WriteLine(elemento);
}

enterosLista2.Clear();



Console.WriteLine();





/*

Console.WriteLine("=================");
//Restricciones a los Genericos
int[] enteros = { 1, 2, 3 };

int numero = new int();
DateTime fecha = new DateTime();

string[] nombres = { "Kaibil57", "Danisaurio", "LemusSSJ", "Quiquefinnxd", "Davidunam" };

DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

Console.WriteLine($"Longitud de arreglo de entero {CalcularLongitudDeArregloV2<int>(enteros)}");
Console.WriteLine($"Longitud de arreglo de entero {CalcularLongitudDeArregloV2<string>(nombres)}");

Carro[] carros = { new Carro() };
Console.WriteLine($"Longitud del arreglo de carros {CalcularLongitudDeArregloV2(carros)}");

Carro[] camiones = { new Camion() };
Console.WriteLine($"Longitud del arreglo de carros {CalcularLongitudDeArregloV2(camiones)}");


int CalcularLongitudDeArregloV2<T>(T[] arreglo) where T: Vehiculo, new()
{
    return arreglo.Length;
}




Console.WriteLine();

Console.WriteLine($"Primer elemento del arreglo de enteros {PrimerElementoOValorPorDefecto(enteros)}");
Console.WriteLine($"Primer elemento del arreglo de enteros {PrimerElementoOValorPorDefecto(nombres)}");
Console.WriteLine($"Primer elemento del arreglo de enteros {PrimerElementoOValorPorDefecto(fechas)}");

Console.WriteLine();

Console.WriteLine($"Ultimo elemento del arreglo de enteros {UltimoElementoOValorPorDefecto(enteros)}");
Console.WriteLine($"Ultimo elemento del arreglo de enteros {UltimoElementoOValorPorDefecto(nombres)}");
Console.WriteLine($"Ultimo elemento del arreglo de enteros {UltimoElementoOValorPorDefecto(fechas)}");


int CalcularLongitudDeArreglo<T>(T[] arreglo)
{
    return arreglo.Length;
}

T PrimerElementoOValorPorDefecto<T>(T[] arreglo)
{
    if (arreglo.Length == 0)
    {
        return default;
    }

    return arreglo[0];
}

T UltimoElementoOValorPorDefecto<T>(T[] arreglo)
{
    if (arreglo.Length == 0)
    {
        return default;
    }

    return arreglo[^1];
}


var utilidadesArregloStrings = new UtilidadesArreglos<string>();
*/