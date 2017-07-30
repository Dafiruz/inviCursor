using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inviCursor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDificuldade_Click(object sender, EventArgs e)
        {
            if (picCursor.Visible==true)
            {
                picCursor.Visible = false;
            }
            else
            {
                picCursor.Visible = true;
            }
        }

        private void btnFácil_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            
            /*Form4 Form4 = new Form4();
            Form4.Show();*/
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
