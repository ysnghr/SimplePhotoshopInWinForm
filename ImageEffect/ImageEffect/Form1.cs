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

namespace ImageEffect
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        Bitmap cropedphoto;
        Point LocationXY;
        Point LocationX1Y1;
        bool MouseDownIs = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pbx1_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownIs = true;
            LocationXY = e.Location;
        }

        private void pbx1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDownIs == true)
            {
                LocationX1Y1 = e.Location;
                Refresh();
            }
        }

        private void pbx1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (MouseDownIs == true)
                {
                    LocationX1Y1 = e.Location;
                    MouseDownIs = false;
                    if (rect !=null)
                    {
                        Bitmap bit = new Bitmap(pbx1.Image, pbx1.Width, pbx1.Height);
                        Bitmap crop = new Bitmap(rect.Width, rect.Height);

                        Graphics g = Graphics.FromImage(crop);
                        g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel);
                        pbx2.Image = crop;
                        cropedphoto = crop;
                    }
                }
            }
            catch
            {
            }
        }

        private void pbx1_Paint(object sender, PaintEventArgs e)
        {
            if (rect!=null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());

            }
        }

        private Rectangle GetRect()
        {
            rect= new Rectangle();
            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);

            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);
            return rect;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (pbx2.Image !=null)
            {
                SaveFileDialog saveimg = new SaveFileDialog();
                saveimg.Filter = "Image Files(*.gif,*.jpg,*.jpeg,*.png)|*.gif,*.jpg,*.jpeg,*.png";
                if (saveimg.ShowDialog()== DialogResult.OK)
                {
                    if (saveimg.FileName.EndsWith(".jpg"))
                    {
                        pbx2.Image.Save(saveimg.FileName, ImageFormat.Bmp);
                    }
                    else if (saveimg.FileName.EndsWith(".gif"))
                    {
                        pbx2.Image.Save(saveimg.FileName, ImageFormat.Gif);
                    }
                    else if (saveimg.FileName.EndsWith(".jpeg"))
                    {
                        pbx2.Image.Save(saveimg.FileName, ImageFormat.Jpeg);
                    }
                    else if (saveimg.FileName.EndsWith(".png"))
                    {
                        pbx2.Image.Save(saveimg.FileName, ImageFormat.Png);
                    }
                }
            }
        }

        private void btnupload_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pbx1.Image = new Bitmap(dlg.FileName);
                }
            }
        }

        private void effect1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width;x++)
                {
                    Color p = bmp.GetPixel(x,y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x,y, Color.FromArgb(a, r, 40, 20));
                    gbmp.SetPixel(x,y, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(x,y, Color.FromArgb(a, 0, 0, b));

                }
            }
            pbx2.Image = rbmp;
        }

        private void effect2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 40, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                }
            }
            pbx2.Image = gbmp;
        }

        private void effect3_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 40, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));

                }
            }
            pbx2.Image = bbmp;
        }

        private void effect4_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 40, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(b, 0, 50, r));

                }
            }
            pbx2.Image = bbmp;
        }

        private void effect5_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(a, r, 40, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(g, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(b, 0, 50, r));

                }
            }
            pbx2.Image = gbmp;
        }

        private void effect6_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(g, b, 40, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(g, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(b, 0, 50, r));

                }
            }
            pbx2.Image = rbmp;
        }

        private void effect7_Click(object sender, EventArgs e)
        {
            Bitmap bmp = cropedphoto;
            int width = bmp.Width;
            int height = bmp.Height;
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color p = bmp.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;
                    rbmp.SetPixel(x, y, Color.FromArgb(r, b, g, 20));
                    gbmp.SetPixel(x, y, Color.FromArgb(g, 0, g, 0));
                    bbmp.SetPixel(x, y, Color.FromArgb(b, 0, 50, r));

                }
            }
            pbx2.Image = rbmp;
        }
    }
}
