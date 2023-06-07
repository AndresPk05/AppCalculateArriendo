using System;
using System.Windows.Forms;

namespace AppCalculateArriendo
{
    public partial class Form1 : Form
    {
        private decimal valorArriendo = 967300;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                var resultadoValidacion = validarDatosMinimos();
                if(resultadoValidacion.Item2)
                {
                    MessageBox.Show(resultadoValidacion.Item1);
                    return;
                }

                var luz = int.Parse(txtLuz.Text);
                var gas = int.Parse(txtGas.Text);
                var agua = int.Parse(txtAgua.Text);

                var valorPagar = (((luz + gas + agua) + valorArriendo) / 3);
                lvalorPerson.Text = valorPagar.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al calcular el valor a pagar por persona");
            }
        }

        private (string, bool) validarDatosMinimos()
        {
            var luz = txtLuz.Text;
            if (string.IsNullOrEmpty(luz))
            {
                return ("No se ha informado el valor a pagar de luz", true);
            }

            var gas = txtGas.Text;
            if (string.IsNullOrEmpty(gas))
            {
                return("No se ha informado el valor a pagar de gas", true);
            }

            return (string.Empty, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lamountArriendo.Text = valorArriendo.ToString();
        }
    }
}
