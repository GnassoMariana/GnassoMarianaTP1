using GnassoMarianaTP1.Entidades;
using System.ComponentModel.DataAnnotations;
using Utilidades;

internal class Program
{
    private static void Main(string[] args)
    {
        int cantidadPiramides = ExtensionesConsola.PreguntarYAgregar("Ingresar otra piramide?", () =>
        {
            Console.WriteLine("Piramides:");
            Console.Clear();
            var lado = ExtensionesConsola.PedirEntero("Ingresar el valor del lado:");
            var altura = ExtensionesConsola.PedirEntero("Ingresar su altura:");

            PiramideCuadrada piramide = new PiramideCuadrada(lado, altura);

            var context = new ValidationContext(piramide);
            var error = new List<ValidationResult>();
            var esValido = Validator.TryValidateObject(piramide, context, error, true);

            if (esValido)
            {

                Console.WriteLine(piramide.InformarDatos());
            }
            else
            {
                foreach (var e in error)
                {
                    Console.WriteLine(e.ErrorMessage);
                }
            }

            

        });

        Console.WriteLine($"Se ingresaron {cantidadPiramides} piramides.");
        Console.ReadLine();


    }
}