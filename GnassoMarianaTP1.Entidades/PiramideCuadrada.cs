using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GnassoMarianaTP1.Entidades
{
    public class PiramideCuadrada: IValidatableObject
    {
        private readonly int lado;
        private readonly int altura;

        private double Apotema { get; set; }

        public int Lado => lado;

        public int Altura => altura;

        public PiramideCuadrada(int lado, int altura)
        {
            this.lado = lado;
            this.altura  = altura;
        }

        private double CalcularApotema()
        {
            return Math.Sqrt(Math.Pow(lado / 2, 2) + Math.Pow(altura, 2));
        }
        public double CalcularArea()
        {
            var areaBase= Math.Pow(lado,2);
            var areaLateral = 2 * lado * CalcularApotema();
             return areaBase + areaLateral;
        }

        public double CalcularVolumen()
        {
            return (Math.Pow(lado,2) * altura) / 3;
        }

        public string InformarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Piramide cuadrada:");
            datos.AppendLine($"Lado de la base: {Lado}");
            datos.AppendLine($"Altura: {Altura}");
            datos.AppendLine("Resultados:");
            datos.AppendLine($"Volumen: {CalcularVolumen()}");
            datos.AppendLine($"Area: {CalcularArea()}");
            datos.AppendLine($"Apotema: {CalcularApotema()}");

            return datos.ToString();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(lado <= 0)
            {
                yield return new ValidationResult("El lado debe ser mayor a cero.");
            }
            if(altura <= 0)
            {
                yield return new ValidationResult("La altura debe ser mayor a cero.");
            }
        }

        public override string ToString()
        {
            return $"Piramide de lado: {Lado} y altura: {Altura}";
        }

        public string ValidarConMensaje()
        {
            var context = new ValidationContext(this);
            var errores = new List<ValidationResult>();
            bool esValido = Validator.TryValidateObject(this, context, errores, true);

            if (esValido)
            {
                return this.ToString() ;
            }
            else
            {
                StringBuilder mensajeError = new StringBuilder();
                foreach (var error in errores)
                {
                    mensajeError.AppendLine(error.ErrorMessage);
                }
                return mensajeError.ToString();
            }
        }
    }
}
