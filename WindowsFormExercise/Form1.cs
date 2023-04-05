using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormExercise
{
    public partial class Form1 : Form
    {
        private List<string> listQ12;
        public Form1()
        {
            InitializeComponent();

            listQ12 = new List<string>();
        }

        private void txtQ12_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!int.TryParse(e.KeyChar.ToString(), out _))
            {
                e.Handled = true;
                return;
            }
            btnQ12Add.Enabled = true;
        } 
        private void btnQ12Add_Click(object sender, EventArgs e)
        {
            listQ12.Add(txtQ12.Text);
            txtQ12.Text = string.Empty;

            listQ12
        }
    }
}
