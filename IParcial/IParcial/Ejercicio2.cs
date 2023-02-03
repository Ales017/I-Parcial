using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            if (Numero1textBox.Text == "")
            {
                errorProvider1.SetError(Numero1textBox, "Ingrese un valor");
                return;
            }
            if (Numero2textBox.Text == "")
            {
                errorProvider1.SetError(Numero2textBox, "Ingrese un valor");
                return;
            }
            if (OperacionescomboBox.Text == "")
            {
                errorProvider1.SetError(OperacionescomboBox, "Seleccione una opción");
                return;
            }
            errorProvider1.Clear();
            decimal resultado = Ejecutar(Convert.ToDecimal(Numero1textBox.Text), Convert.ToDecimal(Numero2textBox.Text));
            
            Resultadolabel.Text = Convert.ToString(resultado);
        }
        
        private decimal Ejecutar(decimal num1, decimal num2)
        {
            string operacion = OperacionescomboBox.Text;
            decimal resultado = 0;

            if (operacion == "Suma")
            {
                resultado = resultado + num1 + num2;
            }
            else if (operacion == "Resta")
            {
                resultado = num1 - num2;
            }
            else if (operacion == "Multiplicacion")
            {
                resultado = num1 * num2;
            }
            else if (operacion == "Division")
            {
                resultado = num1 / num2;
            }                         
            return resultado;
        }
    }
}
