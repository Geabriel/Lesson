using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoGDI
{
    public partial class MainForm : Form
    {
        private int countPaint;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            //1
            Graphics ghr = e.Graphics;
            Pen pen = new Pen(Color.Red, 5);
            ghr.DrawRectangle(pen,50,50,150,150);
            countPaint++;
            this.Text = countPaint.ToString();
            SolidBrush solidBrush = new SolidBrush(Color.Green);
            TextureBrush textureBrush = new TextureBrush(Image.FromFile("dog.jpg"));
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.Cross, Color.OrangeRed);
            LinearGradientBrush linearGradientBrush 
                = new LinearGradientBrush(new Point(10,0), new Point(200,0), Color.Red, Color.Green);

            ghr.FillRectangle(linearGradientBrush, 50, 50, 150, 150);
            ghr.DrawString("C# .NET", new Font("Arial", 50), linearGradientBrush, 350, 350);
        }

        private void btnDrowRec_Click(object sender, EventArgs e)
        {
            //2
            Graphics grh = this.CreateGraphics();
            Pen pen = new Pen(Color.Red, 5);
            grh.DrawRectangle(pen, 250, 250, 150, 150);
            countPaint++;
            this.Text = countPaint.ToString();
            
            //2.1
            //btnDrowRec.CreateGraphics();
        }

        private void btnDrowImege_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap("dog.jpg");
            Graphics grh = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Red, 5);
            grh.DrawEllipse(pen, 250, 250, 150, 150);
            bmp.Save("New_dog.jpg");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(new Rectangle(50, 50, 150, 150));
            //path.AddRectangle(new Rectangle(200, 50, 150, 150));
            //Region regionForm = new Region(path);
            //this.Region = regionForm;
        }
    }
}
