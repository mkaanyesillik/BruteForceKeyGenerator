using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BruteForceKeyGenerator
{
    public partial class BruteForceGenerator : Form
    {

        public BruteForceGenerator()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        int sayac = 0;

        private void btnCreate_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            String str = txtChars.Text.ToString();
            int n = str.Length;
            permute(str, 0, n - 1);
            MessageBox.Show("Tüm Kombinasyonlar Dosyada.","BruteForceGenerator",MessageBoxButtons.OK,MessageBoxIcon.Information);
            sayac = 0;
        }
        public void permute(String str,
                                int l, int r)
        {
            string dosya_yolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\\dosya.txt";
            FileStream fs = new FileStream(dosya_yolu, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            if (l == r) { 
              
            sw.WriteLine(str);
                sayac++;
                lblToplamCikti.Text = "Toplam Çıktı :" + sayac.ToString();


            }
            sw.Flush();
            sw.Close();
            fs.Close();
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r);
                    str = swap(str, l, i);
                }
            }
        }
        public static String swap(String a,
                              int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sayac = 0;
        }
    }
}

