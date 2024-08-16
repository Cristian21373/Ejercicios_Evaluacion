using System;
using System.Threading.Tasks;
using static Ejercicio.Program;


namespace Ejercicio
{
    internal class Program
    {
        public class persona
        {
            public String nombre { get; set; }
            public int edad { get; set; }
            public String direccion { get; set; }

            //Constructor sin parametros
            public persona()
            {
                nombre = "yordy";
                edad = 19;
                direccion = "campo";

            }

            //Constructor con parametros
            public persona(String nombre, int edad, String Direccion)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.direccion = Direccion;
            }

            //Metodo para mostrar datos de la persona
            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Edad: {edad}");
                Console.WriteLine($"Direccion: {direccion}");
            }

            public async Task LeerDatosAsync()
            {
                Console.WriteLine("Obteniendo datos de la persona");
                await Task.Delay(5000); //Retraso de 5 segundos 
                MostrarInformacion();
            }

        }





        public class Empleado : persona, ICalculable
        {
            public int Salario { get; set; }
            public int DiasTrabajados { get; set; }

            public Empleado(string nombre, int edad, string direccion, int salario, int diasTrabajados)
                : base(nombre, edad, direccion)
            {
                this.Salario = salario;
                this.DiasTrabajados = diasTrabajados;
            }






            public double CalcularSalario()
            {

                double operacion = Salario / 30;
                return operacion * DiasTrabajados;

            }






            public override void MostrarInformacion()
            {
                base.MostrarInformacion();
                Console.WriteLine($"Salario: {Salario}");
                Console.WriteLine($"Dias trabajados: {DiasTrabajados}");
                Console.WriteLine($"Total: {CalcularSalario()}");
            }

            public async Task LeerDatosAsync()
            {
                Console.WriteLine("Leyendo datos del empleado");
                await Task.Delay(5000); //Retraso de 5 segundos 
                MostrarInformacion();
            }
        }


        //    Muestra datos normal sin async y await

        //static void Main(string[] args)
        //{
        //    persona persona = new persona();
        //    persona.MostrarInformacion();

        //    Console.WriteLine();

        //    persona = new persona();
        //    persona persona2 = new persona("ana", 20, "Campoalegre");
        //    persona2.MostrarInformacion();

        //    Console.WriteLine();


        //    Empleado empleado = new Empleado("Cristian", 18, "Bogota", 1300000, 6);
        //    empleado.MostrarInformacion();


        //}





        //Muestra datos con async y await
        static async Task Main(string[] args)
        {
            persona persona1 = new persona();
            await persona1.LeerDatosAsync();

            Console.WriteLine();

            persona persona2 = new persona("ana", 20, "Campoalegre");
            await persona2.LeerDatosAsync();

            Console.WriteLine();

            Empleado empleado = new Empleado("Cristian", 18, "Bogota", 1300000, 6);
            await empleado.LeerDatosAsync();
        }
    }
}