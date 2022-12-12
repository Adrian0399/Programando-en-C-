
//Por si acado necesitas usar usuario y password
//var cadenaConexionv2 = "Data Source=LP-CDMX-ADOLVER;Database=AdoNetDemo;Integrated Security=False; User Id=miUsuario; Password=miPassword";

using AdoNetApp;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

using IHost host = Host.CreateDefaultBuilder(args).Build();

var configuración = host.Services.GetService<IConfiguration>();

var cadenaConexión = configuración.GetConnectionString("cadenaDeConexion");

try
{
    using (SqlConnection conexión = new SqlConnection(cadenaConexión))
    {
        // Abrimos la conexión
        conexión.Open();
        Console.WriteLine("Conexión abierta");
        var query = "Personas_Y_Productos";

        using (SqlCommand comando = new SqlCommand(query, conexión))
        {
            comando.CommandType = CommandType.StoredProcedure;
            using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
            {
                var ds = new DataSet();
                adaptador.Fill(ds);

                var tablaPersonas = ds.Tables[0];
                var tablaProductos = ds.Tables[1];

                Console.WriteLine("--Tabla Personas--");
                foreach (DataRow fila in tablaPersonas.Rows)
                {
                    Console.WriteLine($"{fila["Id"]} | {fila["Nombre"]}");
                }

                Console.WriteLine("--Tabla Productos--");
                foreach (DataRow fila in tablaProductos.Rows)
                {
                    Console.WriteLine($"{fila["Id"]} | {fila["Nombre"]} | {fila["Precio"]}");
                }

            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("No pudimos abrir la conexión");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Fin");

await host.RunAsync();

