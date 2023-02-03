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

        private void Sumarbutton_Click(object sender, EventArgs e)
        {
            //Variables
            //decimal Numero1 = Convert.ToDecimal(Numero1textBox.Text);
            //decimal Numero2 = Convert.ToDecimal(Numero2textBox.Text);

            //decimal resultado = Numero1 + Numero2;
            decimal resultado = Convert.ToDecimal(Numero1textBox.Text) + Convert.ToDecimal(Numero2textBox.Text);

            Resultadolabel.Text = Convert.ToString(resultado);

           // MessageBox.Show("La suma es: " + resultado);
        }
    }
}
