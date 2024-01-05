using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlCompositePattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lunghezzaala.Text == string.Empty
                && aperturaala.Text == string.Empty
                && materialefuso.Text == string.Empty
                && lunghezzafuso.Text == string.Empty
                && lunghezzacoda.Text == string.Empty
                && pollicicerchione.Text == string.Empty
                && materialecerchione.Text == string.Empty
                && altezzagomma.Text == string.Empty
                && larghezzagomma.Text == string.Empty
                && raggiogomma.Text == string.Empty)
            {
                MessageBox.Show("Impossibile procedere, inserire la totalità dei parametri.", "Avviso", MessageBoxButtons.OK);
            }
            else
            {
                Ala ala = new Ala(double.Parse(lunghezzaala.Text), double.Parse(aperturaala.Text));
                Fusoliera fusoliera = new Fusoliera(materialefuso.Text, double.Parse(lunghezzafuso.Text));
                Coda coda = new Coda(double.Parse(lunghezzacoda.Text));
                Cerchione cer = new Cerchione(double.Parse(pollicicerchione.Text), materialecerchione.Text);
                Gomma gm = new Gomma(double.Parse(altezzagomma.Text), double.Parse(larghezzagomma.Text), double.Parse(raggiogomma.Text));
                Ruota rt = new Ruota(cer, gm);
                Aliante aln = new Aliante(ala, fusoliera, coda, rt);
            }
        }
    }
}
