using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgyszamjatekGUI
{
    public partial class Form1 : Form
    {
        static List<Jatekos> jatekosok;

        public Form1()
        {
            InitializeComponent();
            Beolvas();
        }

        private void Beolvas()
        {
            jatekosok = new List<Jatekos>();

            var sr = new StreamReader(@"egyszamjatek.txt", Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                jatekosok.Add(new Jatekos(sr.ReadLine()));
            }
            sr.Close();
        }

        private void tbTippek_TextChanged(object sender, EventArgs e)
        {
            lbDb.Text = $"{tbTippek.Text.TrimEnd(' ').Split(' ').Length} db";
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < jatekosok.Count; i++)
            {
                if (jatekosok[i].nev == tbNev.Text)
                {
                    MessageBox.Show("Van már ilyen nevű játékos!", "Hiba!");
                    return;
                }
                if (jatekosok[0].fordulok != tbTippek.Text.Split(' ').Where(x => x.Length != 0).ToList().Count)
                {
                    MessageBox.Show("A tippek száma nem megfelelő!", "Hiba!");
                    return;
                }
            }
            try
            {
                var sw = new StreamWriter("egyszamjatek.txt", true, Encoding.UTF8);
                sw.WriteLine($"{tbNev.Text} {tbTippek.Text.TrimEnd(' ')}");
                MessageBox.Show("Az állomány bővítése sikeres volt!", "Üzenet");
                sw.Close();
                Beolvas();
            }
            catch
            {
                MessageBox.Show("Valami", "Hiba");
            }
        }
    }
}
