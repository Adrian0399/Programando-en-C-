using ManejandoErrores; //Debug WriteLine
using System.Diagnostics; //Debug WriteLine

try 
{ 

ClasesA.ProcesarA();
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("He atrapado la excepcion");
} 




//throw new ExcepcionPersonalizada("Este es un mensaje nuevo de Excepcion");

try
{
    throw new ExcepcionPersonalizada(TipoError.ErrorDelServidor, 
        "Ese es un mensaje nuevo de Excepcion");
}
catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.ErrorDelCliente)
{
    Console.WriteLine("Error del cliente");
}
catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.ErrorDelServidor)
{
    Console.WriteLine("Error del servidor");
}
catch (ExcepcionPersonalizada ex) when (ex.TipoError == TipoError.RecursoNoEncontrado)
{
    Console.WriteLine("Recurso no encontrado");
}

Console.WriteLine("Fin del programa");



Console.WriteLine(" === Manejando Errores === ");
//Console.WriteLine("Antes del error");

//throw new Exception();
//Console.WriteLine("despues del error");

try
{
    Console.WriteLine("Antes del error");
    //ClasesA.ProcesarA();
    Console.WriteLine("Despues del error");
}
/*
catch (NotImplementedException ex)
{
    Console.WriteLine("Ha ocurrido una excepcion ");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Ha ocurrido una excepcion ");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
*/
catch(Exception ex)
{
    Console.WriteLine("Ha ocurrido una excepcion que no se habia contemplado");
}
finally //finaly para ejecutar si o si 
{
    Console.WriteLine("Este es el bloque del finallyy");
}


Console.WriteLine("Fin del programa");



//string separador = "==================";

//ClasesA.ProcesarA();


/*
Console.WriteLine(separador);



Console.WriteLine(separador);
Console.WriteLine("Mensajes de Log con Tracepoints");

var apellido = "Olvera";

Sumar(4, 6);

Console.WriteLine("Fin del programa");

int Sumar(int a, int b)
{
    int c = a + b;
    c++;
    return c;
}




Console.WriteLine(separador);
Console.WriteLine("Debug WriteLine");
//Debug WriteLine


var escritorConsola = new TextWriterTraceListener(System.Console.Out);
var escritorPersonalizado = new TextWriterTraceListener(new EscritorPersonalizado());
Trace.Listeners.Add(escritorConsola);
Trace.Listeners.Add(escritorPersonalizado);


Console.WriteLine("Esta linea se ha ejecutado");

var cantidad1 = 4;

Console.WriteLine($"El valor de la variables : {cantidad1}");

Debug.WriteLine("Este mensaje solo aparece en modo debug");
*/