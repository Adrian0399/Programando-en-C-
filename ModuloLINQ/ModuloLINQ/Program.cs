

using ModuloLINQ;

int[] numeros = Enumerable.Range(1, 20).ToArray();

var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();   

var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();


//Ejemplo 2: Coleccion de Objetos

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
};


//CHUNK
int[] numeros9 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var resultado = numeros9.Chunk(3);


//DISCTINCT Y DISTINCT BY 
var personas7 = new List<Persona>() {
new Persona { Nombre = "Eduardo", EmpresaId = 1, },
new Persona { Nombre = "Nidia",  EmpresaId = 1 },
new Persona { Nombre = "Eduardo"},
new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
};

int[] numeros8 = { 1, 2, 3, 1, 1, 6 };

var numerosSinRepeticion = numeros8.Distinct();

var personasSinRepeticion = personas.DistinctBy(p => p.Nombre);



//GROUPBY
var personas6 = new List<Persona>() {
    new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
    new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
    new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
    new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
};

var agrupamientoPorSoltería = personas6.GroupBy(p => p.Soltero);

foreach (var grupo in agrupamientoPorSoltería)
{
    Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");

    foreach (var persona in grupo)
    {
        Console.WriteLine($"- {persona.Nombre}");
    }
}


//SKIP Y TAKE
var numeros7 = Enumerable.Range(1, 100);

var primeros10Numeros = numeros7.Take(10).ToList();
var segundoLoteDe10 = numeros7.Skip(10).Take(10).ToList();

var últimos10Números = numeros7.TakeLast(10).ToList();
var penúltimoLoteDe10 = numeros7.SkipLast(10).TakeLast(10).ToList();



//CUANTIFICADORES UNIVERSALES
var personas5 = new List<Persona>() {
new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
new Persona { Nombre = "Valentina", Edad = 17, Soltero = false }
};

var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

var sonTodosSolteros = personas.All(p => p.Soltero);

var existeMenor = personas.Any(p => p.Edad < 18);

var existePersonaMayorDe35 = personas.Any(p => p.Edad > 35);

Console.WriteLine();




//MINBY y MAXBY

var personas4 = new List<Persona>() {
new Persona { Nombre = "Eduardo", Soltero = true, Edad = 19 },
new Persona { Nombre = "Nidia", Soltero = true, Edad = 25 },
new Persona { Nombre = "Alejandro", Soltero = true, Edad = 30 },
new Persona { Nombre = "Valentina", Soltero = false, Edad = 22 }
};

// Mínimo
var edadMinima2 = personas4.Min(p => p.Edad);
var personaConLaEdadMásPequeña = personas4.MinBy(p => p.Edad);

// Máximo
var edadMáxima2 = personas4.Max(p => p.Edad);
var personaConLaEdadMásGrande = personas4.MaxBy(p => p.Edad);



//FUNCIONES ESCALARES
var personas3 = new List<Persona>() {
new Persona { Nombre = "Eduardo", Soltero = true, Edad = 19 },
new Persona { Nombre = "Nidia", Soltero = true, Edad = 25 },
new Persona { Nombre = "Alejandro", Soltero = true, Edad = 30 },
new Persona { Nombre = "Valentina", Soltero = false, Edad = 22 }
};

// Conteo
Console.WriteLine($"La cantidad de personas es {personas3.Count()}");
Console.WriteLine($"La cantidad de personas solteras es {personas3.Count(p => p.Soltero)}");
Console.WriteLine($"El entero más grande es: {int.MaxValue.ToString("N")}");
Console.WriteLine($"El long más grande es: {long.MaxValue.ToString("N")}");
Console.WriteLine($"La cantidad de personas es {personas3.LongCount()}");

var numeros6 = Enumerable.Range(1, 5);

// Sumar
var suma = numeros6.Sum();
var sumaEdades = personas3.Sum(p => p.Edad);

// Mínimo

var mínimo = numeros6.Min();
var edadMinima = personas3.Min(p => p.Edad);

// Máximo

var máximo = numeros6.Max();
var edadMáxima = personas3.Max(p => p.Edad);

// Promedio

var promedio = numeros6.Average();
var edadPromedio = personas3.Average(p => p.Edad);




//SELECT-MANY 
// Ejemplo 1: Seleccionar telefonos sin personas

var personas2 = new List<Persona>() {
new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
new Persona { Nombre = "Valentina" }
};

var telefonos = personas2.SelectMany(p => p.Telefonos).ToList();

// Ejemplo 2: Entendiendo SelectMany con dos colecciones diferentes

int[] numeros5 = { 1, 2, 3 };

var personasYNumeros = personas2.SelectMany(p => numeros5, (persona, numero) => new
{
    Persona = persona,
    Numero = numero
});

foreach (var item in personasYNumeros)
{
    Console.WriteLine($"{item.Persona.Nombre} - {item.Numero}");
}

// Ejemplo 3: personas y telefonos

var personasYTelefonos = personas2.SelectMany(p => p.Telefonos, (persona, telefono) =>
new {
    Nombre = persona.Nombre,
    Telefono = telefono
});

foreach (var item in personasYTelefonos)
{
    Console.WriteLine($"{item.Nombre} - {item.Telefono}");
}

Console.WriteLine();




//Proyectando con Select
//Ejemplo 1: Seleccionar una propiedad
var nombres = personas.Select(p => p.Nombre).ToList();

//EJemplo 2: Seleccionar varias propiedades
var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad }).ToList();

//Ejemplo 3: Proyectar hacia una clase
var personasDTOs = personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }).ToList();

//Ejemplo 4: Realizar una operacion
var numeros4 = Enumerable.Range(1, 5).ToList();
var numerosDuplicados = numeros4.Select(n => n * 2).ToList();

//Ejemplo 5: Tomar el Indice
var nombresConOrden = personas.Select((persona, indice) => 
    new { Nombre = persona.Nombre, Orden = indice +1 }).ToList();

foreach (var item in nombresConOrden)
{
    Console.WriteLine($"{item.Orden}.- {item.Nombre}");
}


Console.WriteLine();






//OrderBy
//Ejemplo 1: Ordenando por edad de manera ascendente
Console.WriteLine("Acendente");
foreach (var persona3 in personas.OrderBy(p => p.Edad))
{
    Console.WriteLine($"{persona3.Nombre} tiene {persona3.Edad} años de edad");
}


//Ejemplo 2: Ordenando por edad de manera descendente
Console.WriteLine("Descendente");
foreach (var persona3 in personas.OrderByDescending(p => p.Edad))
{
    Console.WriteLine($"{persona3.Nombre} tiene {persona3.Edad} años de edad");
}

//Ejemplo 3: Ordenando numeros
int[] numeros3 = { 1, 5, 12, 2, 3, 111, 6 };
var numerosOrdenados = numeros3.OrderBy(x => x).ToList();
foreach (var numero in numerosOrdenados)
{
    Console.WriteLine(numero);
}


Console.WriteLine();




//First y FirstOrDefault
//Ejemplo Simple
var primeraPersona = personas.First();
var primeraPersona_2 = personas.FirstOrDefault();

Console.WriteLine();

//
//¿Que ocurre con una coleccion vacia?
var paises = new List<string>();

//var primerPais = paises.First();
var primerPais2 = paises.FirstOrDefault();

//Agregando filtros
var primeraPersonaMenorDe25 = personas.First(p => p.Edad < 25);
var primeraPersonaMayorDe100 = personas.FirstOrDefault(p => p.Edad > 100); //FirstOrDefault nos permite tener un NULL en este caso que no hay una persona mayor a 100 años, mientras que firs nos arrogaria una excepcion

if(primeraPersonaMayorDe100 is null)
{
    Console.WriteLine("No hay ninguna persona mayor de 100");
}

//combinar funciones de LINQ
var primeraPersonaMayorde60 = personas.Where(p => p.Edad > 60).FirstOrDefault();

var numeros2 = new List<int>();
var primerNumero = numeros2.FirstOrDefault();

Console.WriteLine();


//Filtrando con la coleccion Where
var personasDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();
foreach (var persona in personasDe25AñosOMenos)
{
    Console.WriteLine($"Where - {persona.Nombre} tiene {persona.Edad} años.");
}

var solteros= personas.Where(p => p.Soltero).ToList();

foreach (var persona in solteros)
{
    Console.WriteLine ($"Where - {persona.Nombre} es soltero/a");
}

Console.WriteLine();

var solterosMenoresDe25 = personas.Where(p => p.Edad <= 25 && p.Soltero).ToList();
foreach (var persona in solterosMenoresDe25)
{
    Console.WriteLine($"Where - {persona.Nombre} es soltero/a y es menor de 25");
}
var solterosMenoresDe25v2 = personas.Where(p => p.Edad <= 25 && !p.Soltero).ToList();
foreach (var persona in solterosMenoresDe25v2)
{
    Console.WriteLine($"Where - {persona.Nombre} NO es soltero/a y es menor de 25");
}

var fechaActual = DateTime.Today;

var personasConMenosDe3MesesEnLaEmpresa = personas.Where( p =>
p.FechaIngresoALaEmpresa >= fechaActual.AddMonths(-3)).ToList();
foreach (var persona in personasConMenosDe3MesesEnLaEmpresa)
{
    Console.WriteLine($"Where - {persona.Nombre} tiene menos de 3 meses en la empresa.");
}




//Forma 1: Esto es LINQ (sintaxis de metodos)
//Paso 1: Ejecuccion diferida
//FUncion Where nos sirve para realizar filtros, de esta manera podemos especififcar 
//las carateristicas de los elemtos que nosotros queremos consultar


var numerosPares = numeros.Where(n => 
{
    Console.WriteLine($"Evaluando si {n} es par");
    return n % 2 == 0;

}).ToList(); // Si se quita el ToList, se realiza la consulta una por una, y no se imprime la lista de golpe


Console.WriteLine();

foreach (var numero in numerosPares)
{
    Console.WriteLine($"El numero {numero} es par");
}

Console.WriteLine();





//Forma 2: Sintaxis de queries 
//var numerosPares2 = (from n in numeros
//                    where n % 2 == 0
//                    select n).ToList();