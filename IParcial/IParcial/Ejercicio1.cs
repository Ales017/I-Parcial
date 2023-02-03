using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IParcial
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        decimal sumaTotal = 0;
        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            //Variables
            decimal Numero1 = Convert.ToDecimal(Numero1textBox.Text);
            decimal Numero2 = Convert.ToDecimal(Numero2textBox.Text);

            //decimal resultado = Numero1 + Numero2;
            //decimal resultado = Convert.ToDecimal(Numero1textBox.Text) + Convert.ToDecimal(Numero2textBox.Text);

            // Resultadolabel.Text = Convert.ToString(resultado);

            // MessageBox.Show("La suma es: " + resultado);

            //Sumar(Numero1, Numero2);
            sumaTotal = Sumatoria(Numero1, Numero2);
            MessageBox.Show("La suma es: " + sumaTotal ,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Procedimiento
        private void Sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }

        //Funcion
        private decimal Sumatoria(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
