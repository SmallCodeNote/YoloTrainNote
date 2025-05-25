using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormStringCnvClass;


namespace subtool
{

    public partial class Form1 : Form
    {
        string thisExeDirPath;
        public Form1()
        {
            InitializeComponent();
            thisExeDirPath = Path.GetDirectoryName(Application.ExecutablePath);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "TEXT|*.txt";
            if (false && ofd.ShowDialog() == DialogResult.OK)
            {
                WinFormStringCnv.setControlFromString(this, File.ReadAllText(ofd.FileName));
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                if (File.Exists(paramFilename))
                {
                    WinFormStringCnv.setControlFromString(this, File.ReadAllText(paramFilename));
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FormContents = WinFormStringCnv.ToString(this);

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "TEXT|*.txt";

            if (false && sfd.ShowDialog() == DialogResult.OK)
            {

                File.WriteAllText(sfd.FileName, FormContents);
            }
            else
            {
                string paramFilename = Path.Combine(thisExeDirPath, "_param.txt");
                File.WriteAllText(paramFilename, FormContents);
                File.WriteAllText(paramFilename, FormContents);
                File.WriteAllText(paramFilename, FormContents);
            }

        }

        private void PictureBoxUpdate(PictureBox p, Bitmap img)
        {
            if (p.Image != null) p.Image.Dispose();
            p.Image = img;
        }
        
        /*
          dataset/
         ├── images/
         │   ├── train/
         │   ├── val/
         ├── labels/
         │   ├── train/
         │   ├── val/

        */

        private void button_CreateDataSet_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();

            if (!Directory.Exists(textBox_CreateDirPath.Text)) { Directory.CreateDirectory(textBox_CreateDirPath.Text); }

            int imageWidth = int.Parse(textBox_Width.Text);
            int imageHeight = int.Parse(textBox_Height.Text);
            int imageCount = int.Parse(textBox_ImageCount.Text);

            string imagesPath = Path.Combine(textBox_CreateDirPath.Text, "dataset", "images");
            string labelsPath = Path.Combine(textBox_CreateDirPath.Text, "dataset", "labels");
            string imageCat = "train";
            float trainRate = 0.8f;

            foreach (string imageCatBuff in new[] { "train", "val" })
            {
                Directory.CreateDirectory(Path.Combine(imagesPath, imageCatBuff));
                Directory.CreateDirectory(Path.Combine(labelsPath, imageCatBuff));
            }

            int maxObjectCount = 1;
            int objTypeCount = 5;

            List<string> labels = new List<string>();
            imageCat = "train";

            for (int i = 0; i < imageCount; i++)
            {
                labels.Clear();
                Bitmap bitmap = new Bitmap(imageWidth, imageHeight, PixelFormat.Format24bppRgb);
                DrawPattern.drawBackground(bitmap, Color.White);

                int objCount = (int)(rdm.NextDouble() * maxObjectCount + 1.0);

                for (int c = 0; c < objCount; c++)
                {
                    int objIndex = (int)(rdm.NextDouble() * objTypeCount);

                    switch (objIndex)
                    {
                        case 0: labels.Add(DrawPattern.drawCircle(0, bitmap, Color.Red, rdm)); break;
                        case 1: labels.Add(DrawPattern.drawCircle(1, bitmap, Color.Green, rdm)); break;
                        case 2: labels.Add(DrawPattern.drawSquare(2, bitmap, Color.Red, rdm)); break;
                        case 3: labels.Add(DrawPattern.drawRectangle(3, bitmap, Color.Red, 4f, rdm)); break;
                        case 4: labels.Add(DrawPattern.drawRectangle(4, bitmap, Color.Blue, 4f, rdm)); break;
                    }
                }

                if (imageCat =="train" && i > imageCount * trainRate) { imageCat = "val"; };

                PictureBoxUpdate(pictureBox1, bitmap);
                bitmap.Save(Path.Combine(imagesPath, imageCat, i.ToString("0000") + ".jpg"), ImageFormat.Jpeg);
                File.WriteAllLines(Path.Combine(labelsPath, imageCat, i.ToString("0000") + ".txt"), labels);
            }
        }
    }
}
