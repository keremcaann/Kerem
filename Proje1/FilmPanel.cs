using Proje1.Nhibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje1
{
    public partial class FilmPanel : Form
    {
        public FilmPanel()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Film ekleme
            using (var session = NhibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var film = new Model.Film()
                    {
                        FilmAdi = textBox1.Text,
                        Tarih = dateTimePicker1.Value
                    };
                    session.Save(film);
                    transaction.Commit();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var film = new Model.Film()
                    {
                        FilmAdi = textBox1.Text,
                        Tarih = dateTimePicker1.Value,
                        Saat = dateTimePicker2.Value
                    };
                    session.Save(film);
                    transaction.Commit();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FilmPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
