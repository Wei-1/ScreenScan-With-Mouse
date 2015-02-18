using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int form_width = 260;
            int form_height = 238;

            Form cForm = new Form();
            cForm.Size = new Size(form_width, form_height);
            cForm.Location = new Point(Cursor.Position.X - form_width / 2, Cursor.Position.Y - form_height / 2);

            Bitmap cImage = new Bitmap(cForm.Size.Width, cForm.Size.Height);
            Graphics.FromImage(cImage).CopyFromScreen(cForm.Location, Point.Empty, cForm.Size);
            cForm.Dispose(); // Important script: keep memory clean

            pictureBox1.Image = cImage;
            GC.Collect(); // Important script: keep memory clean
        }
    }
}
