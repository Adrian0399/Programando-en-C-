using System.Diagnostics;

namespace Concurrencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Locks

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio");

            var valorConInterlocked = 0;
            var valorConInterlocked2 = 0;

            Parallel.For(0, 10_000, numero =>
            {
                Interlocked.Increment(ref valorConInterlocked);
                Interlocked.Add(ref valorConInterlocked2, valorConInterlocked);
            });

            Console.WriteLine("--Usando dos interlockeds--");
            Console.WriteLine("Valor incrementado: " + valorConInterlocked);
            Console.WriteLine("Valor sumado: " + valorConInterlocked2);

            var valorIncrementado = 0;
            var valorSumado = 0;

            var mutex = new object();

            Parallel.For(0, 10_000, numero =>
            {
                // realizar las operaciones necesarias en paralelo...

                // esta parte la necesitamos secuencial
                lock (mutex)
                {
                    valorIncrementado++;
                    valorSumado += valorIncrementado;
                }
            });

            Console.WriteLine("--Usando lock--");
            Console.WriteLine($"Valor Incrementado: {valorIncrementado}");
            Console.WriteLine($"Valor Sumado: {valorSumado}");


            Console.WriteLine("Fin");
        }



        //InterLocked
        /*

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Inicio");

            var valorSinInterlocked = 0;

            Parallel.For(0, 1_000_000, numero => valorSinInterlocked++);

            Console.WriteLine($"Sumatoria sin interlocked: {valorSinInterlocked}");

            var valorConInterlocked = 0;

            Parallel.For(0, 1_000_000, numero => Interlocked.Increment(ref valorConInterlocked));

            Console.WriteLine($"Sumatoria con interlocked: {valorConInterlocked}");

            Console.WriteLine("Fin");
        }
        */





        //Multlipicar matrices en paralelo
        /*
        private async void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;

            int conteoColumnas = 1080;
            int conteoFilas = 1000;
            int conteoColumnas2 = 750;

            double[,] m1 = MatrizUtilidades.InicializarMatriz(conteoFilas, conteoColumnas);
            double[,] m2 = MatrizUtilidades.InicializarMatriz(conteoColumnas, conteoColumnas2);
            double[,] resultado = new double[conteoFilas, conteoColumnas2];

            Console.WriteLine("Ejecutando versión secuencial ...");

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await Task.Run(() =>
            {
                MatrizUtilidades.MultiplicarMatricesSecuencial(m1, m2, resultado);
            });

            stopwatch.Stop();
            Console.WriteLine("Duración en segundos de la versión secuencial: {0}",
                                    stopwatch.ElapsedMilliseconds / 1000.0);

            resultado = new double[conteoFilas, conteoColumnas2];

            Console.WriteLine("Ejecutando la versión en paralelo");
            stopwatch.Reset();
            stopwatch.Start();
            await Task.Run(() =>
            {
                MatrizUtilidades.MultiplicarMatricesParalelo(m1, m2, resultado);
            });

            stopwatch.Stop();
            Console.WriteLine("Duración en segundos de la versión en paralelo: {0}",
                                    stopwatch.ElapsedMilliseconds / 1000.0);


            //pictureBox1.Visible = false;

        }
        */






        //Parallel.For 
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("--Contemos del 1 al 10 de manera secuencial--");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--Contemos del 1 al 10 en paralelo --");

            Parallel.For(1, 11, i => Console.WriteLine(i));
        }
        */






        /*
        // descargar imagenes en secuencia y paralelo
        HttpClient httpClient = new HttpClient();

        private async void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;

            var directorioActual = AppDomain.CurrentDomain.BaseDirectory;
            var destinoBaseSecuencial = Path.Combine(directorioActual, @"Imagenes\resultado-secuencial");
            var destinoBaseParalelo = Path.Combine(directorioActual, @"Imagenes\resultado-paralelo");

            PrepararEjecucion(destinoBaseParalelo, destinoBaseSecuencial);
            Console.WriteLine("Inicio");
            var imagenes = ObtenerImagenes();

            // parte secuencial

            Stopwatch sw = new Stopwatch();
            sw.Start();

            foreach (var imagen in imagenes)
            {
                await ProcesarImagen(destinoBaseSecuencial, imagen);
            }
            Console.WriteLine($"Secuencial - duracion en segundos es {sw.ElapsedMilliseconds / 1000.0}");

            sw.Reset();

            // parte en paralelo

            sw.Start();

            var tareasEnumerable = imagenes.Select(async imagen =>
            {
                await ProcesarImagen(destinoBaseParalelo, imagen);
            });

            await Task.WhenAll(tareasEnumerable);

            sw.Stop();

            Console.WriteLine(
               $"Paralelo - duración en segundos es {sw.ElapsedMilliseconds / 1000.0}");

            pictureBox1.Visible = false;
        }

        private async Task ProcesarImagen(string directorio, Imagen imagen)
        {
            var respuesta = await httpClient.GetAsync(imagen.URL);
            var contenido = await respuesta.Content.ReadAsByteArrayAsync();

            Bitmap bitmap;
            using (var ms = new MemoryStream(contenido))
            {
                bitmap = new Bitmap(ms);
            }
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            var destino = Path.Combine(directorio, imagen.Nombre);
            bitmap.Save(destino);
        }

        private void PrepararEjecucion(string destinoBaseParalelo,
            string destinoBaseSecuencial)
        {
            if (!Directory.Exists(destinoBaseParalelo))
            {
                Directory.CreateDirectory(destinoBaseParalelo);
            }
            if (!Directory.Exists(destinoBaseSecuencial))
            {
                Directory.CreateDirectory(destinoBaseSecuencial);
            }

            BorrarArchivos(destinoBaseParalelo);
            BorrarArchivos(destinoBaseSecuencial);

        }

        private void BorrarArchivos(string directorio)
        {
            var archivos = Directory.EnumerateFiles(directorio);
            foreach (var archivo in archivos)
            {
                File.Delete(archivo);
            }
        }

        private List<Imagen> ObtenerImagenes()
        {
            var imagenes = new List<Imagen>();

            for (int i = 0; i < 7; i++)
            {
                imagenes.Add(new Imagen()
                {
                    Nombre = $"Casa {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Rotunda_of_Galerius_%28February_2009%29.jpg/800px-Rotunda_of_Galerius_%28February_2009%29.jpg"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"Templo de Ades {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/The_Parthenon_in_Athens.jpg/800px-The_Parthenon_in_Athens.jpg"
                });

                imagenes.Add(new Imagen()
                {
                    Nombre = $"NAZIS {i}.png",
                    URL = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3b/Bundesarchiv_Bild_101I-164-0389-23A%2C_Athen%2C_Hissen_der_Hakenkreuzflagge.jpg/421px-Bundesarchiv_Bild_101I-164-0389-23A%2C_Athen%2C_Hissen_der_Hakenkreuzflagge.jpg"
                });
            }

            return imagenes;
        }
        */





        /*
        private async Task RealizarProcesamientoLargoA()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso A finalizado");
        }
        private async Task RealizarProcesamientoLargoB()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso B finalizado");
        }
        private async Task RealizarProcesamientoLargoC()
        {
            await Task.Delay(1000);
            Console.WriteLine("Proceso C finalizado");
        }
        */
        ////private async Task<string> ObtenerNombre()
        ////{
        ////await Task.Delay(100);
        ////   return "Adrian";
        ////}

    }
}
