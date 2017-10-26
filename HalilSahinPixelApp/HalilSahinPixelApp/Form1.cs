using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalilSahinPixelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Red = new List<int>();
        List<int> Green = new List<int>();
        List<int> Blue = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = OpenFD.ofd();
            Bitmap bmp = new Bitmap(ofd.FileName);
            pictureBox1.ImageLocation = ofd.FileName;

            FillLists.FillAllLists(Red, Green, Blue, bmp);

            SortAll.SortRGB(Red, Green, Blue);
            double Red_AVG = Red.Average();
            double Green_AVG = Green.Average();
            double Blue_AVG = Blue.Average();

            //Pixel Counts
            listBox1.Items.Add("Toplam Pixel Sayısı ;" + Red.Count);

            //Colors Averages
            listBox1.Items.Add("Kırmızı Renk Ortalama Değeri : " + Red_AVG.ToString());
            listBox1.Items.Add("Yeşil Renk Ortalama Değeri : " + Green_AVG.ToString());
            listBox1.Items.Add("Mavi Renk Ortalama Değeri : " + Blue_AVG.ToString());

            //Colors Medians
            listBox1.Items.Add("Kırmızı Medyan : " + Median.GetMedian(Red));
            listBox1.Items.Add("Yeşil Medyan : " + Median.GetMedian(Green));
            listBox1.Items.Add("Mavi Medyan : " + Median.GetMedian(Blue));

            //Colors Mods
            listBox2.Items.Add("Kırmızı Mod ;" +Mod.Get_Mod(Red));
            listBox2.Items.Add("Yeşil Mod ;" + Mod.Get_Mod(Green));
            listBox2.Items.Add("Mavi Mod ;" + Mod.Get_Mod(Blue));

            //Colors Deviations
            listBox2.Items.Add("Kırmızı Standart Sapması ;" + Standard_Deviation.CalculateDeviation(Red));
            listBox2.Items.Add("Yeşil Standart Sapması ;" + Standard_Deviation.CalculateDeviation(Green));
            listBox2.Items.Add("Mavi Standart Sapması ;" + Standard_Deviation.CalculateDeviation(Blue));

            //Colors Skewnwsses and Stickinesses
            listBox2.Items.Add("Kırmızı Çarpıklık ;" + Skewness_Stickiness.Skewness(Red_AVG,Median.GetMedian(Red),Standard_Deviation.CalculateDeviation(Red)));
            listBox2.Items.Add("Kırmızı Basıklık ;" + Skewness_Stickiness.Stickiness(Red));
            listBox2.Items.Add("Yeşil Çarpıklık ;" + Skewness_Stickiness.Skewness(Green_AVG, Median.GetMedian(Green), Standard_Deviation.CalculateDeviation(Green)));
            listBox2.Items.Add("Yeşil Basıklık ;" + Skewness_Stickiness.Stickiness(Green));
            listBox2.Items.Add("Mavi Çarpıklık ;" + Skewness_Stickiness.Skewness(Blue_AVG, Median.GetMedian(Blue), Standard_Deviation.CalculateDeviation(Blue)));
            listBox2.Items.Add("MAvi Basıklık ;" + Skewness_Stickiness.Stickiness(Blue));




        }

    }
}
