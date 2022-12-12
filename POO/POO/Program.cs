using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using POO;
using Utilidades;


var puntoA = new PuntoClase(1, 2);
var puntoB = new PuntoClase(1, 2);

//Error
var sonLosStructsIguales = puntoA == puntoB;
var sonLosStructsIgualesV2 = puntoA.Equals(puntoB);

Console.WriteLine("Son iguales con ==: " + sonLosStructsIguales);

Console.WriteLine("Son iguales con Equals: " + sonLosStructsIgualesV2);

/*

int cantidad1 = 3;
int cantidad2 = 4;
int suma = cantidad1 + cantidad2;

string nombre = "Adrian";
string apellido = "Gavilan";
string nombreCompleto = nombre + apellido;

var v1 = new Vector2D { X = 1, Y = 2 };
var v2 = new Vector2D { X = 3, Y = 4 };
//var v3 = v1 + v2;
var v3 = v1.Sumar(v2);
Console.WriteLine($"Coordenas resultantes: ({v3.X}, {v3.Y})");



/*
var hostBuilder = Host.CreateDefaultBuilder(args);
hostBuilder = hostBuilder.ConfigureServices(ConfigurarServicios);
using var host = hostBuilder.Build(); //Este using ayuda para limpiar recursos, SENTENCIA USING

var almacenadorArchivos = host.Services.GetRequiredService<IAlmacenadorArchivos>();
almacenadorArchivos.Editar("Archivo anterior", "Archivo Nuevo");

void ConfigurarServicios(IServiceCollection services)
{
    services.AddTransient<IAlmacenadorArchivos, AlmacenadorArchivosAWS>();
    services.AddTransient<ControladorDePeliculas>();
    services.AddTransient<OtroLugar>();
}


/*
var claseA = new ClaseA();
var claseB = new ClaseB();

Procesar(claseA);
Procesar(claseB);

void Procesar(IMiSegundaInterfaz miSegundaInterfaz)
{
    miSegundaInterfaz.MiMetodoDeLaSegundaInterfaz();
}




/*
string separador = "===================";

var clasePublicaDePrueba = new ClasePublicaDePrueba();
clasePublicaDePrueba.PropiedadPublica = 1;
clasePublicaDePrueba.MetodoPublico();
//clasePublicaDePrueba.MetodoPrivado(); 
//clasePublicaDePrueba.PropiedadInternal();
//clasePublicaDePrueba.PropiedadProtectedInternal = 7;





/* POO
var carro = new Carro("Toyota");
var camion = new Camion();
var bicicleta = new Bicicleta();
Console.WriteLine(separador);

Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Herencia con Records");
//Solo se puede dar cuando un record de clase hereda de otro record de clase,
//Un record no puede heredar de una clase, una clase no puede heredar de un record,
//Un record strock no puede participar en una relacion de herencia

//var profesor = new Profesor();
//profesor



Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Clase base de todas las clases: Object");
carro.ToString();
var carroString = carro.ToString();
Console.WriteLine("Carro String; " + carroString);

AceptoCualquierParametro(carro);
AceptoCualquierParametro(new Camion());
//AceptoCualquierParametro("Adrian");
AceptoCualquierParametro(42);
//AceptoCualquierParametro(DateTime.Now);
void AceptoCualquierParametro (object objeto)
{
    Console.WriteLine("----- Incio del metodo -----");

    //var carro = objeto as Carro; //Casteo, si falla simplemente sera null

    if (objeto is Carro carro)
    {
        Console.WriteLine("El objeto es un carro");
        carro.SonarClaxon();
    }
    else if (objeto is Camion camion)
    {
        Console.WriteLine("EL objeto es un camion");
        camion.DarReversa();
    }
    else if (objeto is int entero)
    {
        Console.WriteLine("El objeto es un entero: " + entero);
    }
    else
    {
        Console.WriteLine("El objeto no es un carro");
    }


    Console.WriteLine("----- Fin del metodo -----");
}


Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Clases Abstractas");

//var vehiculo = new Vehiculo(); No se puede implementar esto ya que la clase es abstracta
carro.Acelerar(200);
Console.WriteLine("La velocidad del carro es: " + carro.Velocidad);

bicicleta.Acelerar(200);
Console.WriteLine("La velocidad del carro es: " + bicicleta.Velocidad);




Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Sobreescribiendo metodos: virtual");
Console.Write("Carro: ");
carro.DarReversa();
Console.WriteLine("--");

Console.Write("Camion: ");
camion.DarReversa();
Console.WriteLine("--");

Console.Write("Bicicleta: ");
bicicleta.DarReversa();
Console.WriteLine("--");




Console.WriteLine(separador);
Console.WriteLine(separador);
Console.WriteLine("Introduccion a la herencia Herencia");


//var carro = new Carro();
carro.Marca = "Toyota";
carro.EncenderRadio();

//var camion = new Camion();
camion.Marca = "Mercedes";
//camion.EncenderRadio(); // Encender radio solo le pertenece a la subclase Carro

//var bicicleta = new Bicicleta();
bicicleta.Marca = "Benotto";

LeerMarca(carro);
LeerMarca(camion);
LeerMarca(bicicleta);

void LeerMarca(Vehiculo vehiculo)
{
    var mensaje = $"Leyendo la marca {vehiculo.Marca} del vehiculo de tipo {vehiculo}";
    Console.WriteLine(mensaje);
}
*/