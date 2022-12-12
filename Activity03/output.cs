using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Activity03
{
    public partial class output : Form
    {
        
        public output()
        {
            InitializeComponent();
        }

        private void output_Load(object sender, EventArgs e)
        {
            label1.Text="Size is: "+Form1.size.ToString();
            label2.Text="Toppings: "+Form1.toppings.ToString();
            label3.Text = "Crust is: " + Form1.crustType.ToString();
            label4.Text=Form1.eatOption.ToString();
        }
    }
}
