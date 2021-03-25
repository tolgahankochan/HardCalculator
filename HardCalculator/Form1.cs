using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        double sayi1, sayi2, sonuc;
        int secim = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 3;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 4;
        }

        private void Seçilibutonlar(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text = textBox1.Text + ((Button)sender).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",")<1)
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 2;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(textBox1.Text);
            if(secim==1)
            {
                sonuc = sayi1 + sayi2;
                textBox1.Text = sonuc.ToString();
            }
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
                textBox1.Text = sonuc.ToString();
            }
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
                textBox1.Text = sonuc.ToString();
            }
            sayi2 = double.Parse(textBox1.Text);
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
                textBox1.Text = sonuc.ToString();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1); //en son sayıdan itibaren sil
            if(textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(textBox1.Text);
            textBox1.Text = "0";
            secim = 1;
        }
    }
}
