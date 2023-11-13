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

namespace CRUD_file_accesso_diretto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int LunghezzaRecord = 64;

        private void Aggiungi_Click(object sender, EventArgs e)
        {
            var file = new FileStream("File.txt", FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(file);
            sw.WriteLine($"{Prodotto.Text};{Prezzo.Text};1;0;".PadRight(LunghezzaRecord - 4) + "##");
            sw.Close();
        }

        private void Resetta_Click(object sender, EventArgs e)
        {
            var file = new FileStream("File.txt", FileMode.Truncate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(file);
            sw.Write(string.Empty);
            sw.Close();
        }

        public int Ricerca(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return riga;
                    }
                    riga++;
                }
            }
            return -1;
        }

        public string[] Ricercaprodotto(string nome)
        {
            int riga = 0;
            using (StreamReader sr = File.OpenText("File.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] dati = line.Split(';');
                    if (dati[3] == "0" && dati[0] == nome)
                    {
                        sr.Close();
                        return dati;
                    }
                    riga++;
                }
            }
            return null;
        }

        private void CERCA_Click(object sender, EventArgs e)
        {
            string[] nomeprod = Ricercaprodotto(RIcercaProdottoTEXT.Text);
            ModificaProdotto.Text = nomeprod[0];
            ModificaPrezzo.Text = nomeprod[1];

        }

        //Pulsante modifica
        private void Modifica_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(RIcercaProdottoTEXT.Text);
            string line;
            var file = new FileStream("File.txt", FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            file.Seek(LunghezzaRecord * indice, SeekOrigin.Begin);
            line = $"{ModificaProdotto.Text};{ModificaPrezzo.Text};1;0;".PadRight(LunghezzaRecord - 4) + "##";
            byte[] bytes = Encoding.UTF8.GetBytes(line);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
            file.Close();
        }

        private void RIcercaProdottoTEXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancellazioneLogica_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(cancellazioneLogicaTEXT.Text);
            string[] prodotto = Ricercaprodotto(cancellazioneLogicaTEXT.Text);
            string line;
            var file = new FileStream("File.txt", FileMode.Open, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(file);
            file.Seek(LunghezzaRecord * indice, SeekOrigin.Begin);
            line = $"{prodotto[0]};{prodotto[1]};{prodotto[3]};1;".PadRight(LunghezzaRecord - 4) + "##";
            byte[] bytes = Encoding.UTF8.GetBytes(line);
            writer.Write(bytes, 0, bytes.Length);
            writer.Close();
            file.Close();
        }

        private void CancellazioneFisica_Click(object sender, EventArgs e)
        {
            int indice = Ricerca(cancellazionefisicaTEXT.Text);
            string[] line = File.ReadAllLines("File.txt");
            for (int i = indice; i < line.Length - 1; i++)
            {
                line[i] = line[i + 1];
            }

            var file = new FileStream("File.txt", FileMode.Truncate, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(file);
            sw.Write(string.Empty);
            sw.Close();

            var files = new FileStream("File.txt", FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sws = new StreamWriter(files);
            for (int i = 0; i < line.Length - 1; i++)
            {
                sws.WriteLine(line[i]);
            }
            sws.Close();
        }

        private void Recupera_Click(object sender, EventArgs e)
        {
            string[] riga = File.ReadAllLines("File.txt");
            for (int i = 0; i < riga.Length; i++)
            {
                string[] a = riga[i].Split(';');
                if (a[3] == "1" && a[0] == RecuperaTEXT.Text)
                {
                    a[i] = $"{a[0]};{a[1]};1;0;";
                    File.WriteAllLines("File.txt", a);
                    break;
                }
            }
        }
    }
}


