namespace Activity01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 1;

            for(int i = 0; i < 50; i++)
            {
                this.progressBar1.Value++;
            }
        }
    }
}