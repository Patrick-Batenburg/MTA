using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Project_3_2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.MouseClick += (s, e) => MessageBox.Show(String.Format("Mouse Clicked at X: {0} Y: {1}", e.X, e.Y));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
