using GnassoMarianaTP1.Entidades;
using Utilidades;

namespace GnassoMarianaTP1.Windows
{
    public partial class frmPiramides : Form
    {
        public frmPiramides()
        {
            InitializeComponent();
        }
        private List<PiramideCuadrada> piramides = new List<PiramideCuadrada>();
        private void guardarButton_Click(object sender, EventArgs e)
        {
            int lado = 0;
            int altura = 0;


            if(!(int.TryParse(ladoTextBox.Text, out lado) || int.TryParse(alturaTextBox.Text, out altura))) 
            {
                MessageBox.Show("Se debe ingresar un numero entero");
                LimpiarControles();
            }
            else
            {
                var guardarLado = int.TryParse(ladoTextBox.Text, out lado);
                var guardarAltura = int.TryParse(alturaTextBox.Text, out altura);

                PiramideCuadrada piramide = new PiramideCuadrada(lado, altura);

                bool piramideExistente = piramides.Any(p => p.Lado == piramide.Lado && p.Altura == piramide.Altura);

                if (!piramideExistente)
                {
                    string mensaje = piramide.ValidarConMensaje();
                    if (mensaje.StartsWith("Piramide"))
                    {
                        piramides.Add(piramide);
                        piramidesListBox.Items.Add(mensaje);
                        ActualizarCantidad();

                        var agregarMas = MessageBox.Show("Agregar otra piramide?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (agregarMas == DialogResult.Yes)
                        {
                            LimpiarControles();
                        }
                        else
                        {
                            guardarButton.Enabled = false;
                            MessageBox.Show("Carga finalizada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Errores:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("La piramide ya esta en la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }




        private void ActualizarCantidad()
        {
            cantidadLabel.Text = $"Cantidad de piramides ingresadas: {piramides.Count}";
        }

        private void LimpiarControles()
        {
            ladoTextBox.Clear();
            alturaTextBox.Clear();
            ladoTextBox.Focus();

        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
