using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace WinFormsApp5
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Card(string nameProduct, int cost, string photo)
        {
            label1.Text = nameProduct;
            label2.Text = cost.ToString();
            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, photo));
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
