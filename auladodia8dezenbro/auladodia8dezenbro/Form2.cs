using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auladodia8dezenbro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void keydown(object sender, KeyEventArgs e)
        {
            tela1.AppendText("\r\n" + "prissionei a tecla: " + e.KeyCode) ;
            tela1.AppendText("\r\n" + "\t" + "codigo da tecla: " + ((int)e.KeyCode));

            tela1.Text = botaolimpar
                .text;
        }
    }
}
