using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                return;
            }
            if (dateTimePickerDatum.Value == DateTime.MinValue)
            {
                MessageBox.Show("Adja meg a mennyiséget!");
                return;
            }
            if (string.IsNullOrEmpty(richTextBoxSzoveg.Text))
            {
                MessageBox.Show("Nem adott meg szöveget!");
                return;
            }

            saveFileDialog1.Filter = "Egyszerű szöveg fájl (*.txt)|*.txt|Veszővel tagolt szövegfájl (*.csv) |*.csv|Minden fájl|*.*";
            saveFileDialog1.DefaultExt = "*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string szoveg = string.Join(";", textBoxNev.Text + ";" + dateTimePickerDatum.Value, richTextBoxSzoveg.Text);
                string kiveFile = saveFileDialog1.FileName;
                if (File.Exists(saveFileDialog1.FileName))
                {
                    File.Delete(saveFileDialog1.FileName);
                }

                File.WriteAllText(kiveFile, szoveg);
                //MessageBox.Show("A kiválaszott fájl:" + kiveFile);
                textBoxNev.Text = "";
                richTextBoxSzoveg.Text = "";
                dateTimePickerDatum.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Nincs kiválasztva!");
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string kivFile = openFileDialog1.FileName;
                string beolvasottSzoveg = File.ReadAllText(kivFile);
                string[] adatok = beolvasottSzoveg.Split(';');
                textBoxNev.Text = adatok[0];
                richTextBoxSzoveg.Text = adatok[2];
                dateTimePickerDatum.Value =DateTime.Parse(adatok[1]);
            }
        }
    }
}
