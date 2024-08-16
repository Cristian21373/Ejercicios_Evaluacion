using System;
using System.Threading.Tasks;

namespace Ejercicio_con_entrada_de_datos
{
    internal class Program
    {
        public class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string Direccion { get; set; }
            public int Salario { get; set; }
            public int DiasTrabajados { get; set; }
            public string Telefono { get; set; }

            // Constructor con entrada de datos por el usuario
            public Persona()
            {
                Console.Write("Ingrese el nombre: ");
                Nombre = Console.ReadLine();

                Console.Write("Ingrese la edad: ");
                Edad = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese la direccion: ");
                Direccion = Console.ReadLine();

                Console.Write("Ingrese el telefono: ");
                Telefono = Console.ReadLine();

                Console.Write("Ingrese el salario: ");
                Salario = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ingrese los días trabajados: ");
                DiasTrabajados = Convert.ToInt32(Console.ReadLine());
            }


            

            // Metodo para calcular el salario
            public double CalcularSalario()
            {
                double operacion = Salario / 30;
                return operacion * DiasTrabajados;
            }

            // Metodo para mostrar datos de la persona
            public void MostrarInformacion()
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("| Datos obtenidos:  |");
                Console.WriteLine("--------------------");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Edad: {Edad}");
                Console.WriteLine($"Dirección: {Direccion}");
                Console.WriteLine($"Teléfono: {Telefono}");
                Console.WriteLine($"Salario: {Salario}");
                Console.WriteLine($"Días trabajados: {DiasTrabajados}");
                Console.WriteLine($"Total salario calculado: {CalcularSalario():F2}");
            }

            public async Task LeerDatosAsync()
            {
                Console.WriteLine("");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("| Obteniendo datos de la persona. Por favor espere...  |");
                Console.WriteLine("-------------------------------------------------------");
                await Task.Delay(5000); // Retraso de 5 segundos 
                MostrarInformacion();
            }
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Crear una persona");
            Persona persona1 = new Persona();
            await persona1.LeerDatosAsync();
        }
    }
}
