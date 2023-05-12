using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proje1.Model;
using Proje1.Nhibernate;

namespace Proje1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_click(object sender, EventArgs e)
        {
            FilmPanel filmPanel = new FilmPanel();
            filmPanel.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FilmPanel filmPanel = new FilmPanel();
            filmPanel.Show();
        }
    }
}
