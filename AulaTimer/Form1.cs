using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show ("Tem certeza que deseja sair?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit ();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random num = new Random();

            // criando um objeto da classe Random para gerar números aleatórios​
            int x;
            x = num.Next(0, 10);
            //variável x para receber um número inteiro de 0 a 10​
            listBox1.Items.Add(x);
            // exibindo o número aleatório 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }
    }
}
