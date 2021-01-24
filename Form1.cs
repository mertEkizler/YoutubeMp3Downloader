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
using VideoLibrary;
using MediaToolkit;
using System.Net;

namespace YoutubeMp3Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool FormatDurum = true;

        //true is mp3 indir.
        //false ise mp4 indir.

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelDurum_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)

            //await
        {
            using(FolderBrowserDialog fdb = new FolderBrowserDialog() {Description="Kayıt Klasörü Seç" })
            {
                if (fdb.ShowDialog() == DialogResult.OK)
                {

                    GetTitle();
                    labelDurum.Text = "İndirme İşlemi Başlatıldı, Bekleyiniz.";
                    labelDurum.ForeColor = Color.Orange;
                    var youtube = YouTube.Default;
                    var video = await youtube.GetVideoAsync(textBox1.Text);
                    File.WriteAllBytes(fdb.SelectedPath + @"\" + video.FullName, await video.GetBytesAsync());


                    var inputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = fdb.SelectedPath + @"\" + video.FullName
                    };
                    var outputFile = new MediaToolkit.Model.MediaFile
                    {
                        Filename = $"{fdb.SelectedPath + @"\" + video.FullName}.mp3"
                    };

                    using(var enging = new Engine())
                    {
                        enging.GetMetadata(inputFile);
                        enging.Convert(inputFile,outputFile);
                    }

                    if (FormatDurum == true)
                    {
                        File.Delete(fdb.SelectedPath + @"\" + video.FullName);
                    }
                    else
                    {
                        File.Delete($"{fdb.SelectedPath + @"\" + video.FullName}.mp3");
                    }

                    labelDurum.Text = "İndirme İşlemi Başarıyla Tamamlandı!";
                    labelDurum.ForeColor = Color.Green;

                }
                else
                {
                    MessageBox.Show("Dosya Yolunu Seçin", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void GetTitle()
        {
            WebRequest istek = HttpWebRequest.Create(textBox1.Text);
            WebResponse yanit;
            yanit = istek.GetResponse();
            StreamReader bilgiler = new StreamReader(yanit.GetResponseStream());
            string gelen = bilgiler.ReadToEnd();
            int baslangic = gelen.IndexOf("<title>") + 7;
            int bitis = gelen.Substring(baslangic).IndexOf("</title>");
            string gelenBilgiler = gelen.Substring(baslangic, bitis);
            labelHeader.Text = (gelenBilgiler);


        }

        private void radioButtonMP4_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = false;
        }

        private void radioButtonMP3_CheckedChanged(object sender, EventArgs e)
        {
            FormatDurum = true;
        }
    }
}
