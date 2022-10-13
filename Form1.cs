using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zakladniRidiciStruktury10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mocnitel = int.Parse(comboBox1.SelectedItem.ToString());
            foreach(Control ctrl in panel1.Controls)
            {
                if(ctrl is Label)
                {
                    ctrl.Text = mocnitel.ToString();
                }
                else if(ctrl is TextBox)
                {
                    int mocnenec = int.Parse(ctrl.Text.ToString());
                    int mocnina = 1;
                    for(int i = 1;i<=mocnitel;i++)
                    {
                        mocnina *=mocnenec;
                    }
                    ctrl.Text = mocnina.ToString();
                }
            }
        }
    }
}
