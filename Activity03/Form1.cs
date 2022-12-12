namespace Activity03
{
    public partial class Form1 : Form
    {
        public static string size, crustType, toppings, eatOption;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbSmall.Checked == true)
            {
                size= rbSmall.Text;
            }
            else if(rbMedium.Checked == true)
            {
                size = rbMedium.Text;
            }
            else
            {
                size=rbLarge.Text;
            }

            if (rbThickCrust.Checked == true)
            {
                crustType= rbThickCrust.Text;
            }
            else
            {
                crustType=rbThinCrust.Text;
            }

            if(checkBox1.Checked == true)
            {
                toppings+=checkBox1.Text+", ";
            }
            if(checkBox2.Checked == true)
            {
                toppings += checkBox2.Text + " ,";
            }
            if(checkBox3.Checked == true)
            {
                toppings += checkBox3.Text + " ,";
            }
             if(checkBox4.Checked == true)
            {
                toppings += checkBox4.Text;
            }

            if(rbTakeOut.Checked == true)
            {
                eatOption=rbTakeOut.Text;
            }
            else
            {
                eatOption =rbEatIn.Text;
            }

            output myform = new output();
            myform.ShowDialog();
        }
    }
}