using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado;
                resultado = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                MessageBox.Show(resultado.ToString());
            }
            catch (Exception variableerror)
            {

               // MessageBox.Show(variableerror.ToString());
                // o
                MessageBox.Show(variableerror.Message);

            }
            //opcional se ejecuta siempre
            finally
            {
                MessageBox.Show("hola tarola");
            }
        }
    }
}
