using Archivos;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Text;

string separador = "======================";


//Serializando y Deserealizando  -  Formato JSON

var rutaEjemplo = @"C:\Users\adolvera\source\repos\Archivos\Archivos\personas.json";

var persona = new Persona { Id = 1, Nombre = "Adrian Olvera", Salario = 25.99m };

var json = JsonConvert.SerializeObject(persona);

//Console.WriteLine(json);

using (var sw = new StreamWriter(rutaEjemplo))

{
    sw.Write(json);
}

var contenidoArchivo = File.ReadAllText(rutaEjemplo);
var personaDeserializada = JsonConvert.DeserializeObject<Persona>(contenidoArchivo)!;
Console.WriteLine(personaDeserializada.Nombre);








/*
//StreamReader y StopWatch - LecturaRapida

string rutaEjemplo = @"C:\Users\adolvera\source\repos\Archivos\Archivos\personas grande.csv";

void CodigoDelCurso()
{
    // Creando el archivo grande
    //using (var sw = new StreamWriter(rutaEjemplo, append: false))
    //{
    //    for (int i = 1; i <= 10_000_000; i++)
    //    {
    //        sw.WriteLine($"{i},Persona {i},{i}.00");
    //    }
    //}

    // Prueba 1: ¿Qué tiempo toma File.ReadAllLines? 2.9 segundos (en mi máquina)
    UsandoFileReadAllLines();

    // Prueba 2: ¿Qué tiempo toma el StreamReader? 0.001 segundos (en mi máquina)
    UsandoStreamReader();
}

void UsandoFileReadAllLines()
{
    var reloj = new Stopwatch();

    reloj.Start();

    var primeraLinea = File.ReadAllLines(rutaEjemplo)[0];

    reloj.Stop();

    Console.WriteLine(primeraLinea);
    Console.WriteLine($"Duración de File.ReadAllLines: {reloj.ElapsedMilliseconds / 1000.0} segundos");

}

void UsandoStreamReader()
{
    var reloj = new Stopwatch();

    reloj.Start();

    string primeraLinea_v2;

    // Opción 1: Usar el StreamReader directamente
    //using (var sr = new StreamReader(rutaEjemplo))
    //{
    //    primeraLinea_v2 = sr.ReadLine()!;
    //}

    // Opción 2: usando File.ReadLines (la cual usa el StreamReader internamente)
    primeraLinea_v2 = File.ReadLines(rutaEjemplo).First();

    reloj.Stop();

    Console.WriteLine(primeraLinea_v2);
    Console.WriteLine($"Duración del StreamReader: {reloj.ElapsedMilliseconds / 1000.0} segundos");
}
*/







//Creando un CSV
/*
var rutaEjemplo = @"C:\Users\adolvera\source\repos\Archivos\Archivos\personas.csv";

var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.9m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

var stringBuilder = new StringBuilder();

foreach (var persona in personas)
{
    stringBuilder.AppendLine($"{persona.Id},{persona.Nombre},{persona.Salario}");
}

using (var sw = new StreamWriter(rutaEjemplo, append: false, Encoding.UTF8))
{
    sw.Write(stringBuilder.ToString());
}
*/





//De Listado a Archivo de Texto
/*
var ruta = @"C:\Users\adolvera\source\repos\Archivos\Archivos\personas.txt";

var personas = new List<Persona>
{
    new Persona(){Id = 1, Nombre = "Felipe Gavilán", Salario = 25.99m},
    new Persona(){Id = 2, Nombre = "Claudia Rodríguez", Salario = 155m},
    new Persona(){Id = 3, Nombre = "Roberto Gonzalez", Salario = 42m},
    new Persona(){Id = 4, Nombre = "Mariana Reyes", Salario = 39m},
    new Persona(){Id = 5, Nombre = "Arturo Aristy", Salario = 50m},
};

var stringBuilder = new StringBuilder();
//foreach (var persona in personas)
//{
//    stringBuilder.AppendLine($"{persona.Id} | {persona.Nombre} | {persona.Salario}");
//}

foreach (var persona in personas)
{
    var id = persona.Id.ToString().PadLeft(10, '0');
    var nombre = persona.Nombre.PadLeft(75);
    var salario = persona.Salario.ToString("N2").Replace(".", "").PadLeft(10, '0');
    stringBuilder.AppendLine($"{id}{nombre}{salario}");
}



using (var sw = new StreamWriter(ruta, append: false))
{
    sw.Write(stringBuilder.ToString());
}
*/










Console.WriteLine(separador);
//Stream Writer
/*
var ruta = @"C:\Users\adolvera\source\repos\Archivos\Archivos\ejemplo dispose.txt";
using (var streamWriter = new StreamWriter(ruta, append: true)) //Appens, anexar el texto, no reemplazar
//using lamma al Disponse();
{
    streamWriter.WriteLine("Buenos dias");
    streamWriter.Write("En esta carta");
    streamWriter.WriteLine($"Te informo que la hora es: {DateTime.Now.ToString("hh:mm:ss")}");
    streamWriter.Write("bye");
}




Console.WriteLine("El programa va a ser Detenido. Presione Enter para Finalizar");

Console.Read();

void UsarSW()
{
    using var streamWriter = new StreamWriter(ruta, append: true);
    streamWriter.WriteLine("Buenos dias");
    streamWriter.Write("En esta carta");
    streamWriter.WriteLine($"Te informo que la hora es: {DateTime.Now.ToString("hh:mm:ss")}");
    streamWriter.Write("bye");
}
*/
Console.WriteLine(separador);












Console.WriteLine(separador);
/*
//Clase Directorio
var rutaEjemplo = @"C:\Users\adolvera\source\repos\Archivos\Archivos";

//Directory.CreateDirectory(ruta);

//var rutas = Directory.EnumerateDirectories(rutaEjemplo, "*", SearchOption.AllDirectories);

//foreach (var ruta in rutas)
//{
//    Console.WriteLine(ruta);
//}

var rutas2 = Directory.EnumerateFiles(rutaEjemplo, "*", SearchOption.AllDirectories);

foreach (var ruta in rutas2)
{
    //Console.WriteLine(ruta);
    var nombreArchivo = Path.GetFileName(ruta);
    var extension = Path.GetExtension(ruta);
    Console.WriteLine($"{nombreArchivo} - extension: {extension}");
}

var ruta1 = @"C:\Users\adolvera\source\Archivos";
var ruta2 = @"C:\Users\adolvera";
var rutaCombinada = Path.Combine(ruta1, ruta2);
Console.WriteLine(rutaCombinada);
*/
Console.WriteLine(separador);


Console.WriteLine(separador);
//Clase File
/*
var ruta = @"C:\Users\adolvera\source\repos\Archivos\Archivos\ejemplo.txt";
var rutaDestino = @"C:\Users\adolvera\source\repos\Archivos\Archivos\ejemplo copiado.txt";

Directory.CreateDirectory(ruta);

if (File.Exists(ruta))
{
    var contenido = File.ReadAllText(ruta);
    Console.WriteLine(contenido);
    File.Copy(ruta, rutaDestino, overwrite: true);

}
else
{
    Console.WriteLine("El archivo no fue encontrado");
}

File.Delete(rutaDestino);


var filas = File.ReadAllText(@"C:\Users\adolvera\source\repos\Archivos\Archivos\ejemplo-lineas.txt");

Console.WriteLine();

*/
Console.WriteLine(separador);