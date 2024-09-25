using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator2
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
            string alphabetics = "abcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            string motdepasse = "";

            for(int i = 0; i < 10; i++)
            {
                int alea = random.Next(0, alphabetics.Length);
                char cara = alphabetics[alea];
                motdepasse += cara;
            }

            textBox1.Text = motdepasse;
        }
    }
}
