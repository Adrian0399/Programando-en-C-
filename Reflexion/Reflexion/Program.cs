

using Reflexion;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Reflection;

Saludador.Saludar("Adrian");



/*
//ExpandoObject 

using System.Dynamic;

dynamic objetoExpandible = new ExpandoObject();

objetoExpandible.Nombre = "Adrian";

Console.WriteLine(objetoExpandible.Nombre);

objetoExpandible.Apellido = "Olvera";

Console.WriteLine(objetoExpandible.Apellido);

objetoExpandible.Sumar = new Func<int, int, int>((int a, int b) => a + b);

Console.WriteLine(objetoExpandible.Sumar(1, 2));

var diccionario = (IDictionary<string, object>)objetoExpandible;

Console.WriteLine(diccionario["Nombre"]);

foreach (var llave in diccionario.Keys)
{
    Console.WriteLine(llave);
}

diccionario.Remove("Apellido");

try
{
    Console.WriteLine(objetoExpandible.Apellido);
}
catch (Exception ex)
{
    Console.WriteLine("La propiedad apellido no existe en el ExpandoObject");
}
*/







/*
//Dynamic 

using Newtonsoft.Json;

//dynamic nombre = "Adrian";
//Console.WriteLine(nombre);
//Console.WriteLine(nombre.ToUpper());

//nombre = 99;
//Console.WriteLine(nombre);
//Console.WriteLine(nombre.ToUpper());

var contenidoJSON = File.ReadAllText(@"C:\Users\adolvera\source\repos\Reflexion\Reflexion\persona.json");

dynamic obj = JsonConvert.DeserializeObject<dynamic>(contenidoJSON)!;

Console.WriteLine(obj.nombre);
Console.WriteLine(obj.direcciones[0].calle);

*/







/*
//Atributos Personalizados

using Reflexion;
using System.Reflection;

Console.WriteLine("--Puedes realizar las siguientes acciones--");

foreach (var accion in Enum.GetValues<Acciones>())
{
    var campo = typeof(Acciones).GetField(accion.ToString())!;
    var esconderAtributo = campo.GetCustomAttribute(typeof(EsconderAttribute));

    if (esconderAtributo is not null)
    {
        var esconder = ((EsconderAttribute)esconderAtributo).Ocultar();

        if (esconder)
        {
            continue;
        }
    }

    Console.WriteLine(accion);
}
*/







//Introduccion a los Atributos
/*
using Reflexion;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

var persona = new Persona();

persona.Edad = 17;
persona.OtroNumero = 7;

var errores = ValidarObjeto(persona);

if (errores.Any())
{
    Console.WriteLine("La persona no tiene los datos correctos");

    foreach (var error in errores)
    {
        Console.WriteLine($"- Propiedad: {error.Propiedad}; Mensaje: {error.MensajeDeError}");
    }

    return;
}

Console.WriteLine("La edad de la persona es: " + persona.Edad);

Console.WriteLine("Fin");

bool ValidarPersona(Persona p)
{
    var tipo = p.GetType();

    var propiedadEdad = tipo.GetProperty("Edad")!;

    if (propiedadEdad.IsDefined(typeof(RangeAttribute)))
    {
        var atributoRange = (RangeAttribute)Attribute
                .GetCustomAttribute(propiedadEdad, typeof(RangeAttribute))!;

        return p.Edad >= (int)atributoRange.Minimum && p.Edad <= (int)atributoRange.Maximum;
    }

    return true;
}

IEnumerable<ErrorValidacion> ValidarObjeto(object obj)
{
    var t = obj.GetType();
    var propiedades = t.GetProperties();
    var resultado = new List<ErrorValidacion>();

    foreach (var propiedad in propiedades)
    {
        if (propiedad.IsDefined(typeof(RangeAttribute)))
        {
            var atributoRange = (RangeAttribute)Attribute
                .GetCustomAttribute(propiedad, typeof(RangeAttribute))!;
            var valor = (int)propiedad.GetValue(obj)!;
            var minimo = (int)atributoRange.Minimum;
            var maximo = (int)atributoRange.Maximum;
            var esValido = valor >= minimo && valor <= maximo;
            if (!esValido)
            {
                resultado.Add(new ErrorValidacion
                {
                    Propiedad = propiedad.Name,
                    MensajeDeError = $"El valor debe de estar entre {minimo} y {maximo}"
                });
            }
        }
    }

    return resultado;
}
*/


/*
using Reflexion;
using System.Collections;
using System.Reflection;
//Obteniendo Tipo Base e Interfaces - IsAssignableFrom y IsAssignableTo
// Ejemplo 1: Obteniendo el tipo base

var tipoBaseString = typeof(string).BaseType;
var tipoBaseCarro = typeof(Carro).BaseType;

Console.WriteLine($"La clase base de string es {tipoBaseString}");
Console.WriteLine($"La clase base de carro es {tipoBaseCarro}");

// Ejemplo 2: Obteniendo las interfaces de un tipo

Console.WriteLine("Las interfaces de string son: ");

foreach (var interfaz in typeof(string).GetInterfaces())
{
    Console.WriteLine("- " + interfaz);
}


// Ejemplo 3: Viendo si un tipo hereda de una interfaz o clase

var tipoString = typeof(string);
var tipoIEnumerable = typeof(IEnumerable);

Console.WriteLine("¿String hereda de IEnumerable? " + tipoString.IsAssignableTo(tipoIEnumerable));

Console.WriteLine(
    "¿IEnumerable es implementada por string? " + tipoIEnumerable.IsAssignableFrom(tipoString));

Console.WriteLine("¿Carro hereda de Vehiculo? " + typeof(Carro).IsAssignableTo(typeof(Vehiculo)));
Console.WriteLine("¿Carro hereda de IEnumerable? " + typeof(Carro).IsAssignableTo(tipoIEnumerable));
*/





/*
//Invocando Metodos usando Reflexion

// Ejemplo 1: Invocando un método void sin parámetros 

using Reflexion;
using System.Reflection;

var tipo = typeof(Utilidades);
var utilidades = Activator.CreateInstance(tipo);

tipo.InvokeMember("ImprimirHoraActual", BindingFlags.InvokeMethod,
    binder: null, target: utilidades, args: new object[] { });

// Ejemplo 2: Invocando un método void pasando parámetros

tipo.InvokeMember("ImprimirMensaje", BindingFlags.InvokeMethod,
    binder: null, target: utilidades, args: new object[] { "Usando reflexión" });

// Ejemplo 3: Invocando un método que devuelve un valor

var resultado = tipo.InvokeMember("ObteniendoUnValor", BindingFlags.InvokeMethod,
    binder: null, utilidades, new object[] { });

Console.WriteLine("Obtuvimos el valor: " + resultado);

// Ejemplo 4: Invocando un método estático

tipo.InvokeMember("MetodoEstatico", BindingFlags.InvokeMethod,
    binder: null, target: null, args: new object[] { });

// Ejemplo 5: invocando un método privado

tipo.InvokeMember("MetodoPrivado",
    BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance,
    binder: null, target: utilidades, args: new object[] { });
*/







//Instanciando Tipos Usando Reflexión
/*
// Ejemplo 1: Instanciando una clase por el tipo

using Reflexion;

Type tipo = typeof(Persona);
var personaSinNombreViaType = (Persona)Activator.CreateInstance(tipo)!;

//Console.WriteLine("Persona instanciada por el type " + personaSinNombreViaType);

// Ejemplo 2: Instanciando una clase por su nombre y assembly

var nombreCompletoClasePersona = typeof(Persona).FullName!;
var assemblyClasePersona = typeof(Persona).Assembly.GetName().Name!;

var personaSinNombreViaString = (Persona)Activator.CreateInstance(assemblyClasePersona,
    nombreCompletoClasePersona)!.Unwrap()!;

Console.WriteLine("Persona instanciada por un string " + personaSinNombreViaString);

// Ejemplo 3: Instanciando una clase pasándole valores al constructor

var personaConNombreViaType = (Persona)Activator.CreateInstance(typeof(Persona),
    new object[] { "Adrian Olvera" })!;

Console.WriteLine("El nombre de la persona es " + personaConNombreViaType.Nombre);
*/








//Propiedades de Type
/*
Type tipo = typeof(int);

int edad = 999;
Type tipoDeDatoDeEdad = edad.GetType();

Type tipoDeDatoSystemInt32 = Type.GetType("System.Int32")!;

Console.WriteLine($"¿Es {tipo.Name} un arreglo? {tipo.IsArray}");

Console.WriteLine($"El valor máximo de un entero es (sin reflexión): {int.MaxValue}");

var valor = tipo.GetField("MaxValue")!.GetValue(default(int));

Console.WriteLine($"El valor máximo de un entero es (con reflexión): {valor}");
*/